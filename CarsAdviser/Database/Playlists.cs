using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdviser.Database
{
    public class Playlists
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }

        [ForeignKey("CarID")]
        public virtual Cars Car { get; set; }

        [ForeignKey("UserID")]
        public virtual Users User { get; set; } 
    }
}
