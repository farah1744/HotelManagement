using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.ViewModel
{
    public class RoomViewModel
    {
        public int IdChambre { get; set; }
        public string NumChambre { get; set; }

        public string ImageChambre { get; set; }
        public decimal PrixChambre { get; set; }
        public int BookingStatusId { get; set; }
        public int idTypeChambre { get; set; }
        public int CapaciteChambre { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public string DescriptionChambre { get; set; }
        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListOfRoomType { get; set; }

    }
}