
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdviser.Database
{
    public class Users_preferences
    {
        public int ID { get; set; }

        public int Users_id { get; set; }

        public int Cars_id { get; set; }

        [ForeignKey("Users_id")]
        public virtual Users Users { get; set; }

        [ForeignKey("Cars_id")]
        public virtual Cars Cars { get; set; }
    }
}
