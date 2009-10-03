using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iStatsDev.Web
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config.
    public class Service1 : IService1
    {

        #region IService1 Members

        public List<User> getUserByID(int userID)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var matchingUsers = from user in db.Users
                                where user.UserID.Equals(userID)
                                select user;

            return matchingUsers.ToList();
        }

        public bool SaveUser (User usrObject)
        {
            bool retVal = true;

            DataClassesDataContext db1 = new DataClassesDataContext();

            db1.Addresses.InsertOnSubmit(usrObject.address);

            try
            {
                db1.SubmitChanges();

                Event.logEvent(Event.EventType.Information, usrObject.address.AddressID, "Address saved");
            }
            catch (Exception e)
            {
                Event.logEvent(Event.EventType.Error, usrObject.address.AddressID, e.Message);
                retVal = false;
            }

            usrObject.AddressID = usrObject.address.AddressID;

            DataClassesDataContext db2 = new DataClassesDataContext();

            db2.Users.InsertOnSubmit(usrObject);

            try
            {
                db2.SubmitChanges();

                Event.logEvent(Event.EventType.Information, usrObject.UserNum, "User saved");
            }
            catch (Exception e)
            {
                Event.logEvent(Event.EventType.Error, usrObject.UserNum, e.Message);
                retVal = false;
            }

            return retVal;
        }

        bool LoginUser(string strUser, string strPass)
        {
            return true;
        }

        #endregion
    }
}
