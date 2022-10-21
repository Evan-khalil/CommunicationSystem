using CommunicationApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationApp.Repository
{
    public interface IMeetingRepository : IRepository<Meeting>
    {
        Task<Meeting> GetAllMeetingInfo(Guid meetingId);
        Task<List<Meeting>> GetAllMeetings();
        Task<List<Meeting>> GetAllMeetingsIncludeAttendees();
        Task<List<Meeting>> GetUnansweredInvitesToPerson(string personId);
        Task<Meeting> GetByMeetingDateId(MeetingDate meetingDate);
        Task<int> GetMeetingsToConfirm(string personId);
        int AnswerCounter(Meeting meeting);
    }
}