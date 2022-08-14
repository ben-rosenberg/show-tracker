#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace ShowTracker.Models
{
    public class ShowsBand
    {
        [Key]
        public int ShowsBandId { get; set; }

        public int ShowId { get; set; }
        public Show ShowJoin { get; set; }
        public int BandId { get; set; }
        public Band BandJoin { get; set; }
    }
}