using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAdviser.Database
{
    public class Cars_stamp
    {
        public int ID { get; set; }
        public int Cars_model { get; set; }
        public string Stamp { get; set; }

        [ForeignKey("Cars_model")]
        public virtual Cars_model Cars_Model { get; set; }
    }
}
