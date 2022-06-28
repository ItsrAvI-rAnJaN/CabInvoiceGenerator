using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RidesRepository
    {
        Dictionary<string, List<Rides>> User_Rides = null;

        public RidesRepository()
        {
            User_Rides = new Dictionary<string, List<Rides>>();
        }

        public void AddRides(string User_Id,Rides[] rides)
        {
            bool RidesList =User_Rides.ContainsKey(User_Id);
            try
            {
                if (!RidesList)
                {
                    List<Rides> list = new List<Rides>();
                    list.AddRange(rides);
                    User_Rides.Add(User_Id, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are Null");

            }
        }
        public Rides[] GetRides(string User_Id)
        {
            try
            {
                return this.User_Rides[User_Id].ToArray();

            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid User Id");
            }
        }
    }
}
