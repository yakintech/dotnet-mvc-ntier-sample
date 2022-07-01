﻿using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class WebUserVM
    {
        [Required(ErrorMessage = "Name alanı boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SurName alanı boş bırakılamaz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Email Title alanı boş bırakılamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Password minimum 6 karakter olmalıdır")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password ve Confirm Password alanları aynı olmak zorunda")]
        [Required(ErrorMessage = "Confirm Password alanı boş bırakılamaz")]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
    }
}
