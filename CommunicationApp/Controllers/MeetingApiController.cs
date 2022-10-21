using CommunicationApp.Models;
using CommunicationApp.Models.AjaxModels;
using CommunicationApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationApp.Services;

namespace CommunicationApp.Controllers
{
    [AllowAnonymous]
    [Route("api/meeting/{Action}")] //Detta blir URL: localhost/Api/Meeting/{Action}
    [ApiController]
    public class MeetingApiController : ControllerBase
    {
        private readonly IMailRepository _mail;
        private readonly IPersonRepository _person;
        private readonly IMeetingRepository _meeting;
        private readonly IMeetingDateRepository _meetingDate;

        public MeetingApiController(IPersonRepository personRepository, IMeetingRepository meetingRepository, IMeetingDateRepository meetingDateRepository, IMailRepository mailRepository)
        {
            _person = personRepository;
            _meeting = meetingRepository;
            _meetingDate = meetingDateRepository;
            _mail = mailRepository;
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task AddMeeting([FromBody] AjaxMeeting obj)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                await CreateMeeting(obj);
            }
        }

        private async Task CreateMeeting(AjaxMeeting obj)
        {
            string meetingDatesToChooseFrom = "";

            var recipients = new List<Person>();
            foreach (var person in obj.MeetingPersons)
            {
                recipients.Add(await _person.GetById(person));
            }

            var meetingDates = new List<MeetingDate>();
            foreach (var meetingDate in obj.MeetingDates)
            {
                meetingDatesToChooseFrom += $"<li>{meetingDate.Start.ToString("yyyy-MM-dd dddd HH:mm")}-{meetingDate.End.ToString("HH:mm")}</li>";
                meetingDates.Add(new MeetingDate
                {
                    Start = meetingDate.Start,
                    End = meetingDate.End
                });
            }

            var meeting = new Meeting
            {
                Id = Guid.NewGuid(), //måste sätta GUID, för att kunna få med ID för kallelselänken nedan (mailBody)
                Subject = obj.Title,
                Description = obj.Description,
                Host = await _person.GetByUserName(User.Identity.Name),
                Recipients = recipients,
                DateRequests = meetingDates
            };

            string mailBody = $"{meeting.Host.Name} har kallat dig till mötet:<br />" +
                              $"<b>{meeting.Subject}</b>.<br />" +
                              $"Beskrivning om mötet:<br />" +
                              $"{meeting.Description}<br /><br />" +
                              $"Datum du kan välja på:<br />" +
                              $"<ul>{meetingDatesToChooseFrom}</ul><br /><br />" +
                              $"Logga in för att bekräfta de datum som du kan delta, alternativt meddela om du inte kan komma.<br /><br />" +
                              $"Länk till mötesförfrågan: <a href=\"https://localhost:44351/Meeting/Confirm/{meeting.Id}\">{meeting.Subject}</a>";
            
            //_mail.SendMail(recipients, $"Kallelse till möte: {meeting.Subject}", mailBody);
            
            //var smsService = new SmsService();
            //smsService.SendSms(recipients, $"Du har blivit kallad till ett möte av: {meeting.Host.Name}. Mötet: {meeting.Subject}. Logga in och välj att acceptera eller neka denna inbjudan.");

            await _meeting.Add(meeting);
            await _meeting.Save();
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task EditMeeting([FromBody] AjaxMeeting obj)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                Meeting meeting = await _meeting.GetAllMeetingInfo(obj.Id);
                foreach (var meetingDate in meeting.DateRequests)
                {
                    _meetingDate.Remove(meetingDate.Id);
                }
                _meeting.Remove(obj.Id);

                await CreateMeeting(obj);
            }
        }

        [HttpGet, IgnoreAntiforgeryToken]
        public async Task<List<AjaxCalendarMeeting>> GetMeetingsToCalendar()
        {
            var listOfMeetings = await _meeting.GetAllMeetings();
            var listOfCalendarMeetings = new List<AjaxCalendarMeeting>();

            foreach (var meeting in listOfMeetings)
            {
                if (meeting.FinalDate != null)
                {
                    var listOfParticipants = new List<AjaxCalendarMeetingPerson>();
                    foreach (var person in meeting.FinalDate.Attendees)
                    {
                        listOfParticipants.Add(new AjaxCalendarMeetingPerson
                        {
                            Id = person.Id,
                            Name = person.FirstName + " " + person.LastName
                        });
                    }

                    listOfCalendarMeetings.Add(new AjaxCalendarMeeting
                    {
                        Title = meeting.Subject,
                        Description = meeting.Description,
                        Id = meeting.Id,
                        Host = new AjaxCalendarMeetingPerson
                        {
                            Id = meeting.Host.Id,
                            Name = meeting.Host.FirstName + " " + meeting.Host.LastName
                        },
                        Start = meeting.FinalDate.Start,
                        End = meeting.FinalDate.End,
                        Participants = listOfParticipants
                    });
                }
            }
            return listOfCalendarMeetings;
        }

        [HttpGet, IgnoreAntiforgeryToken]
        public async Task<List<AjaxCalendarMeeting>> GetMeetingsToCalendarPersonal()
        {
            var listOfMeetings = await _meeting.GetAllMeetingsIncludeAttendees();
            var listOfCalendarMeetings = new List<AjaxCalendarMeeting>();

            foreach (var meeting in listOfMeetings.Where(m=>User.Identity != null && m.Host.Email == User.Identity.Name || m.FinalDate != null && m.FinalDate.Attendees.Any(a=>User.Identity != null && a.Email == User.Identity.Name)))
            {
                if (meeting.FinalDate != null)
                {
                    var listOfParticipants = new List<AjaxCalendarMeetingPerson>();
                    foreach (var person in meeting.FinalDate.Attendees)
                    {
                        listOfParticipants.Add(new AjaxCalendarMeetingPerson
                        {
                            Id = person.Id,
                            Name = person.FirstName + " " + person.LastName
                        });
                    }

                    listOfCalendarMeetings.Add(new AjaxCalendarMeeting
                    {
                        Title = meeting.Subject,
                        Description = meeting.Description,
                        Id = meeting.Id,
                        Host = new AjaxCalendarMeetingPerson
                        {
                            Id = meeting.Host.Id,
                            Name = meeting.Host.FirstName + " " + meeting.Host.LastName
                        },
                        Start = meeting.FinalDate.Start,
                        End = meeting.FinalDate.End,
                        Participants = listOfParticipants
                    });
                }
            }
            return listOfCalendarMeetings;
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task AcceptMeetingDate([FromBody] AjaxMeetingAccept obj)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                List<MeetingDate> meetingDates = new();
                Meeting meeting = null;
                foreach (var item in obj.AcceptedMeetingDates)
                {
                    meetingDates.Add(await _meetingDate.GetById(Guid.Parse(item)));
                }
                Person person = await _person.GetByUserName(User.Identity.Name);
                List<Person> subscribers = new();
                string meetingDatesAccepted = "";

                foreach (var meetingDate in meetingDates)
                {
                    meetingDate.Attendees = await _meetingDate.GetAttendees(meetingDate.Id);
                    meetingDate.Attendees.Add(person);
                    meetingDatesAccepted += "<li>" + meetingDate.Start.ToString("yyyy-MM-dd ddd HH:mm") + "-" + meetingDate.End.ToString("HH:mm") + "</li>";
                    if (meeting is null)
                    {
                        try
                        {
                            meeting = await _meeting.GetByMeetingDateId(meetingDate);
                            subscribers.Add(meeting.Host);
                        }
                        catch (Exception)
                        { 
                            //Ignore error
                        }
                    }
                }
                int answerCount = _meeting.AnswerCounter(meeting);

                string mailBody = $"{person.Name} har accepterat datumet för mötet:<br />" +
                                  $"<b>{meeting.Subject}</b>.<br />"+
                                  $"{person.FirstName} kunde vid dessa tillfällen:<br />"+
                                  $"<ul>{meetingDatesAccepted}</ul><br /><br />" +
                                  $"Du har just nu fått: {answerCount} av {meeting.Recipients.Count} svar för detta mötet.<br /><br />" +
                                  $"Mer mötesinformation hittar du här:<br />" +
                                  $"<a href=\"https://localhost:44351/Meeting/Details/{meeting.Id}\">{meeting.Subject}</a> ";
                
                //_mail.SendMail(subscribers, $"{meeting.Subject} accepterat av: {person.Name}", mailBody);

                await _meetingDate.Save();
            }
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task DeclineMeeting([FromBody] AjaxMeetingAccept obj)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                Meeting meeting = await _meeting.GetAllMeetingInfo(Guid.Parse(obj.DeclinedMeeting));
                Person person = await _person.GetByUserName(User.Identity.Name);
                List<Person> reciepents = new List<Person>();
                reciepents.Add(meeting.Host);
                meeting.NonAttenders.Add(person);

                int answerCount = _meeting.AnswerCounter(meeting);

                string mailBody = $"{person.Name} har avböjt ditt möte:<br />" +
                                  $"<b>{meeting.Subject}</b>.<br />" +
                                  $"Du har just nu fått: {answerCount} av {meeting.Recipients.Count} svar för detta mötet.<br /><br />" +
                                  $"Här finns info om mötet: <a href=\"https://localhost:44351/Meeting/Confirm/{meeting.Id} \">{meeting.Subject}</a>";
                
                //_mail.SendMail(reciepents, $"{meeting.Subject} avböjt av: {person.Name}", mailBody);

                await _meeting.Save();
            }
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task ConfirmMeetingDate([FromBody] AjaxMeetingConfirm obj)
        {

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                MeetingDate finalMeetingDate = await _meetingDate.GetById(Guid.Parse(obj.FinalMeetingDate));
                Person person = await _person.GetByUserName(User.Identity.Name);
                Meeting meeting = await _meeting.GetByMeetingDateId(finalMeetingDate);
                List<Person> participants = meeting.Recipients;
                if (meeting.Host.Id.Equals(person.Id) && meeting.Host.UserName.Equals(User.Identity.Name))
                {
                    meeting.FinalDate = finalMeetingDate;

                    string mailBody = $"Mötesvärden {meeting.Host.Name}, har nu satt ett datum för mötet:<br />" +
                                      $"<b>{meeting.Subject}</b><br />" +
                                      $"Datum för mötet blir:<br />" +
                                      $"{meeting.FinalDate.Start.ToString("dddd yyyy-MM-dd HH:mm")} - {meeting.FinalDate.End.ToString("HH:mm")}.<br /><br />" + 
                                      $"Mer information om mötet hittar du här: <a href=\"https://localhost:44351/Meeting/Details/{meeting.Id}\">{meeting.Subject}</a> ";

                    //_mail.SendMail(participants, $"{meeting.FinalDate.Start.ToString("yyyy-MM-dd ddd HH:mm")} sker mötet: {meeting.Subject}", mailBody);
                    //var smsService = new SmsService();
                    //smsService.SendSms($"+467...",$"Mötesvärden {meeting.Host.Name}, har nu satt datumet för mötet {meeting.Subject}, till: {meeting.FinalDate.Start.ToString()}");
                }

                await _meetingDate.Save();
            }
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task Delete([FromBody] AjaxDeleteCalendarMeeting obj)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                Guid id = Guid.Parse(obj.Id);
                var meeting = await _meeting.GetAllMeetingInfo(id);
                var user = await _person.GetByUserName(User.Identity.Name);

                if (User.IsInRole("Admin") || meeting.Host.Id == user.Id)
                {
                    _meeting.Remove(id);
                    await _meeting.Save();
                }
            }
        }
    }
}