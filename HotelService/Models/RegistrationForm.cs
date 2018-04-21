using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelService.Models
{
    public class RegistrationForm
    {
        [Required(ErrorMessage = "Введите ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите вашу фамилию")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Введите ваше отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите ваш телефон")]
        [RegularExpression(@"\d+", ErrorMessage = "Вы ввели некорректный номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Укажите комнату")]
        public Room SelectedRoom { get; set; }
    }
}