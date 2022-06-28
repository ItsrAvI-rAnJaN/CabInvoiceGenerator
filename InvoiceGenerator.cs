using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RidesType ridetype;
        private RidesRepository riderepository;

        private double MINIMUM_COST_PER_KM;
        private double COST_PER_TIME;
        private double MINIMUM_FARE;
        public InvoiceGenerator(RidesType ridetype)

        {
            this.ridetype = ridetype;
            this.riderepository = new RidesRepository();
            try
            {
                if (ridetype.Equals(RidesType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;

                }
                else
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME= 1;
                    this.MINIMUM_FARE = 5;

                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Ivalid Ride Type");
            }
        }

        public  double Calculate_Fare(double Distance, int Time)
        {
            double TotalFare = 0;
            try
            {
                TotalFare =Distance * MINIMUM_COST_PER_KM + Time *COST_PER_TIME;
            }
            catch (CabInvoiceException)
            {
                if (ridetype.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride Type");
                }
                if(Distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance, Distance is not Less than 0");

                }
                if(Time <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, " Invalid Time, Time is not less than 0");
                }

            }
            return Math.Max(TotalFare,MINIMUM_FARE);

        }
         
         

    }
}
