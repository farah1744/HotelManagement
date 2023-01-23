using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using WebApplication9.ViewModel;

namespace WebApplication9.Controllers
{
    public class RoomController : Controller

    {
        private WPFEntities1 objWPFEntities;
        public RoomController()
        {
            objWPFEntities = new WPFEntities1();

        }
        // GET: Room
        public ActionResult Index()
        {
            RoomViewModel objRoomViewModel = new RoomViewModel();

            objRoomViewModel.ListOfBookingStatus = (from obj in objWPFEntities.BookingStatus
                                                    select new SelectListItem()
                                                    {
                                                        Text = obj.BookingStatus,
                                                        Value = obj.BookingStatusId.ToString()
                                                    }).ToList();

            objRoomViewModel.ListOfRoomType = (from obj in objWPFEntities.TypeChambreTs
                                                    select new SelectListItem()
                                                    {
                                                        Text = obj.typeChambre,
                                                        Value = obj.idTypeChambre.ToString()
                                                    }).ToList();
            return View(objRoomViewModel);
        }
    }
}