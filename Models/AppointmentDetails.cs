using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class AppointmentDetail
    {
        public int appointmentdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int visitID { get; set; }
        public virtual Visits Visits { get; set; }
        // the next two properties link the orderDetail to the Product
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }
    }
}