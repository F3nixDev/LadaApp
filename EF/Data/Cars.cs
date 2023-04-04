using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data
{
    [Table("Cars")]
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int TankCapacity { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
