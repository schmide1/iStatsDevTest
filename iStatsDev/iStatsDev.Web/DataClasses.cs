using System;
namespace iStatsDev.Web
{
    partial class DataClassesDataContext
    {
    }
    partial class User
    {
        public enum userTypes : int
        {
            Admin = 0,
            Mod = 1,
            LeagueAdmin = 2,
            TeamCoach = 3,
            Player = 4,
            ScoreRecorder = 5,
            Fan = 6
        }

        public enum userStatus : int    
        {
            Pending = 0,
            Active = 1,
            Locked = 2,
            Closed = 3
        }

        public enum userGender : int
        {
            Male = 0,
            Female = 1
        }

        public Address address;
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

            evnt.DateTime = System.DateTime.Now.ToUniversalTime();
            evnt.Message = message;
            evnt.Type = (int)evntType;
            evnt.UserID = userId;

            DataClassesDataContext db = new DataClassesDataContext();

            db.Events.InsertOnSubmit(evnt);

            try
            {
                db.SubmitChanges();

            }
            catch (Exception e)
            {
                e = e;
            }
        }
    }
}
