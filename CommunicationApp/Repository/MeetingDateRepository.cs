using CommunicationApp.Data;
using CommunicationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public class MeetingDateRepository : Repository<MeetingDate>, IMeetingDateRepository
    {
        private readonly IMeetingRepository _meeting;

        public MeetingDateRepository(ApplicationDbContext identityContext) : base(identityContext)
        {
            _meeting = new MeetingRepository(identityContext);
        }

        public async Task<List<MeetingDate>> AddDateRequest(MeetingDate meetingDate, Guid meetingId)
        {
            Meeting meeting = await _meeting.GetById(meetingId);
            List<MeetingDate> meetingDatesToBeReturned = new List<MeetingDate>();

            meetingDatesToBeReturned = meeting.DateRequests.ToList();
            meetingDatesToBeReturned.Add(meetingDate);
            return meetingDatesToBeReturned;
        }

        public async Task<List<Person>> GetAttendees(Guid meetingDateId)
        {
            List<Person> meetingAttendeesToBeReturned = new List<Person>();
            MeetingDate meetingDate = await GetById(meetingDateId);
            
            if(meetingDate.Attendees is not null)
            {
                meetingAttendeesToBeReturned = meetingDate.Attendees;
            }
            return meetingAttendeesToBeReturned;
        }

        public async Task<List<MeetingDate>> GetDateByMeetingId(Guid meetingId) 
        {
            Meeting meeting = await _meeting.GetAllMeetingInfo(meetingId);
            List<MeetingDate> meetingDatesToBeReturned = meeting.DateRequests;
            return meetingDatesToBeReturned;
        }

    }
}