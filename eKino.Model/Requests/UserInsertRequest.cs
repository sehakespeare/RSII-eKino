﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKino.Model.Requests
{
    public class UserInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }

        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public bool? Status { get; set; }

        public List<int> RoleIdList { get; set; } = new List<int> { };
    }
}
