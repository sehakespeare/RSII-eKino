using eKino.Model;
using System;
using System.Collections.Generic;

namespace eKino.Model
{
    public partial class Projection
    {
        public int ProjectionId { get; set; }
        public DateTime DateOfProjection { get; set; }
        public int AuditoriumId { get; set; }
        public virtual Auditorium Auditorium { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
