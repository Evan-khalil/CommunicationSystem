using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Controllers
{
    [Authorize]
    public class MeetingController : Controller
    {
        private readonly IPersonRepository _person;
        private readonly IMeetingRepository _meeting;
        private readonly IMeetingDateRepository _meetingDate;

        public MeetingController(IPersonRepository personRepository, IMeetingRepository meetingRepository, IMeetingDateRepository meetingDateRepository)
        {
            _person = personRepository;
            _meeting = meetingRepository;
            _meetingDate = meetingDateRepository;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Global Kalender";
            return View();
        }

        public IActionResult PersonalCalendar()
        {
            ViewData["Title"] = "Personlig Kalender";
            return View();
        }

        public async Task<IActionResult> Chooser(Guid Id)
        {
            ViewData["Title"] = "Välj mötesdatum";

            MeetingViewModel viewModel = new();

            try
            {
                viewModel.Meeting = await _meeting.GetAllMeetingInfo(Id);
                viewModel.SelectedDates = new List<string>();
            }
            catch (Exception)
            {
                viewModel = new MeetingViewModel
                {
                    Meeting = new Meeting
                    {
                        Subject = "Blank",
                        Description = "",
                        DateRequests = new List<MeetingDate>(),
                        Host = new Person { FirstName = "", LastName = "" }
                    }
                };
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Confirm(Guid Id)
        {
            ViewData["Title"] = "Bekräfta mötestillfälle";

            MeetingViewModel viewModel = new ();

            //KONTROLLERA ATT HOST ELLER ADMIN kan se detta: 
            try
            {
                viewModel.Meeting = await _meeting.GetById(Id);
                viewModel.SelectedDates = new List<string>();
                viewModel.Meeting.DateRequests = await _meetingDate.GetDateByMeetingId(Id);
            }
            catch (Exception)
            {
                viewModel = new MeetingViewModel
                {
                    Meeting = new Meeting
                    {
                        Subject = "Blank",
                        Description = "",
                        DateRequests = new List<MeetingDate>(),
                        Host = new Person { FirstName = "", LastName = "" }
                    }
                };
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Details(Guid Id)
        {
            ViewData["Title"] = "Mötesinformation";
            Meeting meeting = await _meeting.GetAllMeetingInfo(Id);
            MeetingDetailsViewModel viewModel = new();
            //KONTROLLERA ATT HOST ELLER ADMIN kan se detta: 
            try
            {
                viewModel = new()
                {
                    Id = meeting.Id.ToString(),
                    Host = meeting.Host,
                    Description = meeting.Description,
                    Subject = meeting.Subject
                };

                if(meeting.FinalDate is not null)
                {
                    viewModel.Date = meeting.FinalDate.Start.ToString("yyyy-MM-dd ddd");
                    viewModel.Time = meeting.FinalDate.Start.ToString("t") + "-" + meeting.FinalDate.End.ToString("t");
                    viewModel.Attendees = meeting.FinalDate.Attendees;
                } else
                {
                    viewModel.Date = "Ej satt ännu";
                    viewModel.Time = "00:00";
                    viewModel.Attendees = new List<Person>();
                    viewModel.Attendees.AddRange(meeting.Recipients);
                }
            }
            catch (Exception)
            {
                viewModel = new()
                {
                    Id = "00000000-0000-0000-0000-000000000000",
                    Date = "yyyy-mm-dd",
                    Time = "00:00-00:00",
                    Description = "Hittade inget möte med detta id: " + Id,
                    Host = new Person { FirstName = "", LastName = "" },
                    Attendees = new List<Person>()
                };
            }

            return View(viewModel);
        }

        public async Task<IActionResult> MyMeetings()
        {
            ViewData["Title"] = "Mina möten";
            Person user = await _person.GetByUserName(User.Identity.Name);
            List<Meeting> allMeetings = await _meeting.GetAllMeetings();
            List<Meeting> pendingHostConfirm = new();

            foreach (var meeting in allMeetings)
            {
                foreach (var meetingDate in meeting.DateRequests)
                {
                    if (meetingDate.Attendees.Contains(user) && meeting.Host.Id.Equals(user.Id) is false && meeting.FinalDate is null && pendingHostConfirm.Contains(meeting) is false)
                    {
                        pendingHostConfirm.Add(meeting);
                    }
                }
            }

            MyMeetingsViewModel viewModel = new()
            {
                MeetingsToConfirm = allMeetings.Where(m => m.FinalDate is null && m.Host.Equals(user)).OrderBy(m => m.Subject).ToList(),
                PendingHostConfirm = pendingHostConfirm.OrderBy(m=>m.Subject).ToList(),
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Invites()
        {
            ViewData["Title"] = "Mötesinbjudningar";
            var user = await _person.GetByUserName(User.Identity.Name);

            List<Meeting> viewModel = await _meeting.GetUnansweredInvitesToPerson(user.Id);

            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            ViewData["Title"] = "Skapa möte";
            CreateMeetingViewModel model = new() { AllPersons = await _person.GetAll() };
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid Id)
        {
            ViewData["Title"] = "Uppdatera möte";
            CreateMeetingViewModel model = new() { AllPersons = await _person.GetAll(), Meeting = await _meeting.GetAllMeetingInfo(Id) };
            return View("Create", model);
        }

        public async Task<IActionResult> Info(Guid id)
        {
            if (User.Identity != null)
            {
                var meeting = await _meeting.GetAllMeetingInfo(id);
                var model = new MeetingDetailsViewModel()
                {
                    Id = meeting.Id.ToString(), 
                    Date = meeting.FinalDate.Start.ToString("yyyy-MM-dd ddd"),
                    Time = meeting.FinalDate.Start.ToString("t") + "-" + meeting.FinalDate.End.ToString("t"),
                    Host = meeting.Host,
                    Description = meeting.Description,
                    Attendees = meeting.FinalDate.Attendees
                };
                return PartialView("_Info", model);
            }
            return NotFound();
        }

        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var meeting = await _meeting.GetAllMeetingInfo(id);
            var user = await _person.GetByUserName(User.Identity.Name);

            if (User.IsInRole("Admin") || meeting.Host.Id == user.Id)
            {
                _meeting.Remove(id);
                await _meeting.Save();
            }
            return RedirectToAction("MyMeetings");
        }
    }
}