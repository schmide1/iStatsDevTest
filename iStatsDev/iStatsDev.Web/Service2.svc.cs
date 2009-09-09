using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;

namespace iStatsDev.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service2
    {
        // Add more operations here and mark them with [OperationContract]
        [OperationContract]
        bool SaveUser(User usrObject)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            db.Addresses.InsertOnSubmit(usrObject.address);

            try
            {
                db.SubmitChanges();

                Event.logEvent(Event.EventType.Information, usrObject.UserNum, "Address saved");

            }
            catch (Exception e)
            {
                Event.logEvent(Event.EventType.Error, usrObject.UserNum, e.Message);
            }

            usrObject.AddressID = usrObject.address.AddressID;
            db.Users.InsertOnSubmit(usrObject);

            try
            {
                db.SubmitChanges();

                Event.logEvent(Event.EventType.Information, usrObject.UserNum, "Account saved");

            }
            catch (Exception e)
            {
                Event.logEvent(Event.EventType.Error, usrObject.UserNum, e.Message);
            }

            return true;
        }

    }
}
