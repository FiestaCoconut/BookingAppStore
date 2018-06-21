using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingAppStore.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public string Purchaser { get; set; }

        public string Address { get; set; }

        public float BookId { get; set; }

        public DateTime Date { get; set; }
    }
}