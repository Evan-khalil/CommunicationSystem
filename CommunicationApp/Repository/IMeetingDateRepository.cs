using CommunicationApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public interface IMeetingDateRepository : IRepository<MeetingDate>
    {
        Task<List<MeetingDate>> AddDateRequest(MeetingDate meetingDate, Guid meetingId);
        Task<List<MeetingDate>> GetDateByMeetingId(Guid meetingId);
        Task<List<Person>> GetAttendees(Guid meetingDateId);
    }
}