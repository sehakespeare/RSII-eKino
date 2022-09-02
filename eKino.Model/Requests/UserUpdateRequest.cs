using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class UserUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }

        public bool? Status { get; set; }
    }
}
