using System;

namespace myistats.Web
{
    partial class User
    {
        public enum userTypes : int
        {
            Admin = 0,
            Mod = 1,
            LeagueOwner = 2,
            TeamCoach = 3,
            Player = 4,
            ScoreRecorder = 5
        }

        public enum userStatus : int
        {
            Pending = 0,
            Active = 1,
            Locked = 2,
            Closed = 3
        }
    }

    partial class Event
    {
        public enum EventType : int
        {
            Information = 0,
            Warning = 1,
            Error = 2
        }

        public static void logEvent(EventType evntType, int userId, string message)
        {
            Event evnt = new Event();

            evnt.DateTime = DateTime.Now.ToUniversalTime();
            evnt.Message = message;
            evnt.Type = (int) evntType;
            evnt.UserId = userId;
        }
    }
}