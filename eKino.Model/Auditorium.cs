﻿using System;
using System.Collections.Generic;

namespace eKino.Model
{
    public partial class Auditorium: SoftDeletableEntity
    {
        public int AuditoriumId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
