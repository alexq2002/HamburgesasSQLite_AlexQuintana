using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HamburgesasSQLite_AlexQuintana.Models
{
    [Table("burger")]
    public class BurgerAQ
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool WithExtraCheese { get; set; }
        public DateTime HoraYFechaActual { get; set; }
        public string PortadaPath { get; set; }
    }
}
