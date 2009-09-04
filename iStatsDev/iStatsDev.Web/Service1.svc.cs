using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace myistats.Web
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config.
    public class Service1 : IService1
    {

        #region IService1 Members

        public List<User> getUserByID(int userID)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var matchingUsers = from user in db.Users
                                where user.UserId.Equals(userID)
                                select user;

            return matchingUsers.ToList();
        }

        public bool SaveUser (User usrObject)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            db.Users.InsertOnSubmit(usrObject);

            try
            {
                db.SubmitChanges();

                Event.logEvent(Event.EventType.Information, usrObject.UserId, "Account saved");
                
            }
            catch (Exception e)
            {
                Event.logEvent(Event.EventType.Error, usrObject.UserId, e.Message);
            }

            return true;
        }

        #endregion
    }
}
