using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelService.Models
{
    public class RoomRepository
    {
        public static List<Room> GetRooms()
        {
            return new List<Room>
                       {
                           new Room { Name = "Номер с видом на океан"},
                           new Room { Name = "Одиночный номер"},
                           new Room { Name = "Номер с бассейном и кинотеатром"}
                       };
        }
    }
}