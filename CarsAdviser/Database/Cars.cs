using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAdviser.Database
{
    public class Cars
    {
        public int ID { get; set; }
        public int Cars_model { get; set; }
        public int Cars_stamp { get; set; }
        public int Cars_body { get; set; }
        public int Cars_engine { get; set; }
        public int Cars_fuel { get; set; }
        public int Cars_drive { get; set; }
        public int Cars_checkpoint { get; set; }
        public int Cars_wheel { get; set; }
        public int Cars_colour { get; set; }
        public long Price { get; set; }
        public int TrunkCapacity { get; set; }
        public int? Mark { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public int Engine_power { get; set; }
        public int Qty_places { get; set; }
        public string Description { get; set; }
        public string Photo_1 { get; set; }
        public string Photo_2 { get; set; }
        public string Photo_3 { get; set; }
        public string Photo_4 { get; set; }
        public string Photo_5 { get; set; }

        [ForeignKey("Cars_model")]
        public virtual Cars_model Cars_Model { get; set; }

        [ForeignKey("Cars_stamp")]
        public virtual Cars_stamp Cars_Stamp { get; set; }

        [ForeignKey("Cars_body")]
        public virtual Cars_body Cars_Body { get; set; }

        [ForeignKey("Cars_engine")]
        public virtual Cars_engine Cars_Engine { get; set; }

        [ForeignKey("Cars_fuel")]
        public virtual Cars_fuel Cars_Fuel { get; set; }

        [ForeignKey("Cars_drive")]
        public virtual Cars_drive Cars_Drive { get; set; }

        [ForeignKey("Cars_checkpoint")]
        public virtual Cars_checkpoint Cars_Checkpoint { get; set; }

        [ForeignKey("Cars_wheel")]
        public virtual Cars_wheel Cars_Wheel { get; set; }
   
        [ForeignKey("Cars_colour")]
        public virtual Cars_colour Cars_Colour { get; set; }
    }

}
