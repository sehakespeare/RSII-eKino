﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class UserException : Exception
    {
        public UserException(string message):
            base(message) { }
    }
}
