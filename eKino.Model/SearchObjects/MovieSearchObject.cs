using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.SearchObjects
{
    public class MovieSearchObject : BaseSearchObject
    {
        public string Title { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
        public int DirectorId { get; set; }
    }
}
