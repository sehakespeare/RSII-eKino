using eKino.Model;
using System;
using System.Collections.Generic;

namespace eKino.Model
{
    public partial class Movie
    {

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
        public int RunningTime { get; set; }
        public byte[] Photo { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
    }
}
