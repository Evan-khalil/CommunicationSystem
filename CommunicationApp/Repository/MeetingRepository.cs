using CommunicationApp.Data;
using CommunicationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public class MeetingRepository : Repository<Meeting>, IMeetingRepository
    {
        private readonly IPersonRepository _person;

        public MeetingRepository(ApplicationDbContext identityContext) : base(identityContext)
        {
            _person = new PersonRepository(identityContext);
        }

        public async Task<Meeting> GetAllMeetingInfo(Guid meetingId)
        {
            return await _context.Meetings
                             .Where(m => m.Id.Equals(meetingId))
                             .Include(m => m.DateRequests)
                             .ThenInclude(md=>md.Attendees)
                             .Include(m => m.Host)
                             .Include(m => m.FinalDate)
                             .ThenInclude(x => x.Attendees)
                             .Include(m => m.Recipients)
                             .Include(m=>m.NonAttenders)
                             .FirstOrDefaultAsync();
        }

        public async Task<List<Meeting>> GetAllMeetings()
        {
            return await _context.Meetings
                .Include(m => m.DateRequests)
                .ThenInclude(md => md.Attendees)
                .Include(m => m.Host)
                .Include(m => m.FinalDate)
                .Include(m => m.Recipients)
                .Include(m => m.NonAttenders)
                .ToListAsync();
        }

        public async Task<List<Meeting>> GetAllMeetingsIncludeAttendees()
        {
            return await _context.Meetings
                .Include(m => m.DateRequests)
                .ThenInclude(md => md.Attendees)
                .Include(m => m.Host)
                .Include(m => m.FinalDate)
                .ThenInclude(m=>m.Attendees)
                .Include(m => m.Recipients)
                .Include(m => m.NonAttenders)
                .ToListAsync();
        }

        private async Task<List<Meeting>> GetAllMeetingRecipients()
        {
            return await _context.Meetings
                .Include(m => m.DateRequests)
                .ThenInclude(md => md.Attendees)
                .Include(m => m.NonAttenders)
                .Include(m => m.Host)
                .Include(m => m.Recipients)
                .ToListAsync();
        }

        public async Task<List<Meeting>> GetUnansweredInvitesToPerson(string personId)
        {
            Person person = await _person.GetById(personId);
            List<Meeting> allMeetings = await GetAllMeetingRecipients();
            List<Meeting> listToReturn = new();

            foreach (var meeting in allMeetings)
            {
                bool isNotAttendee = true;
                foreach (var recipient in meeting.Recipients)
                {
                    if (recipient.Id == person.Id)
                    {
                        foreach (var meetingAttendee in meeting.DateRequests)
                        {
                            foreach (var attendee in meetingAttendee.Attendees)
                            {
                                if (recipient.Id == attendee.Id)
                                {
                                    isNotAttendee = false;
                                }
                            }
                        }
                        foreach (var nonAttender in meeting.NonAttenders)
                        {
                            if (meeting.NonAttenders.Count > 0 && nonAttender.Id == person.Id)
                            {
                                isNotAttendee = false;
                            }
                        }
                        if (isNotAttendee)
                        {
                            listToReturn.Add(meeting);
                        }
                    }
                }
            }
            return listToReturn;
        }

        public async Task<Meeting> GetByMeetingDateId(MeetingDate meetingDate)
        {
            List<Meeting> allMeetings = await GetAllMeetings();
            var meetingToReturn = new Meeting();

            foreach (var meeting in allMeetings)
            {
                if (meeting.DateRequests.Contains(meetingDate))
                {
                    meetingToReturn = meeting;
                }
            }
            return meetingToReturn;
        }

        public async Task<int> GetMeetingsToConfirm(string personId)
        {
            Person person = await _person.GetById(personId);

            List<Meeting> meetingsToConfirm = await GetAllMeetings();
            //meetingsToConfirm = meetingsToConfirm.Where(m => m.FinalDate is null && m.Host.Id.Equals(personId)).OrderBy(m => m.Subject).ToList();

            int count = 0;
            foreach (var meeting in meetingsToConfirm)
            {
                if(AnswerCounter(meeting) == meeting.Recipients.Count)
                {
                    count++;
                }
            }
            return count; 
        }

        public int AnswerCounter(Meeting meeting)
        {
            List<Person> personsAnswered = new List<Person>();

            foreach (var invitedPerson in meeting.Recipients)
            {
                foreach (var person in meeting.NonAttenders)
                {
                    if (invitedPerson.Id.Equals(person.Id))
                    {
                        personsAnswered.Add(person);
                    }
                }

                foreach (var meetingDate in meeting.DateRequests)
                {
                    foreach (var person in meetingDate.Attendees)
                    {
                        if (invitedPerson.Id.Equals(person.Id) && personsAnswered.Contains(person) is false)
                        {
                            personsAnswered.Add(person);
                        }
                    }
                }
            }
            return personsAnswered.Count;
        }
    }
}