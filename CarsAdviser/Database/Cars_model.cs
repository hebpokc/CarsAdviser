
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdviser.Database
{
    public class Cars_model
    {
        public int ID { get; set; }
        public int Cars_stamp { get; set; }
        public string Model { get; set; }

        [ForeignKey("Cars_stamp")]
        public virtual Cars_stamp Cars_Stamp { get; set; }
    }
}
