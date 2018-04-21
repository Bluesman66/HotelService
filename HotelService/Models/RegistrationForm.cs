using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelService.Models
{
    public class RegistrationForm
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public Room SelectedRoom { get; set; }
    }
}