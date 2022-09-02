using eKino.Model;
using System;
using System.Collections.Generic;

namespace eKino.Services.Database
{
    public partial class Projection
    {
        public Projection()
        {
            Reservations = new HashSet<Reservation>();
        }
        public int ProjectionId { get; set; }
        public DateTime DateOfProjection { get; set; }
        public int AuditoriumId { get; set; }
        public virtual Auditorium Auditorium { get; set; } = null!;
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; } = null!;
        public ICollection<Reservation> Reservations { get; set; }
    }
}
