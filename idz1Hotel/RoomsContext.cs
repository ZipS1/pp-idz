using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace idz1Hotel
{
    [Table(Name ="Rooms")]
    internal class Rooms
    {
        [Column(IsPrimaryKey =true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "type")]
        public string Type { get; set; }

        [Column(Name = "comforts")]
        public string Comforts { get; set; }

        [Column(Name = "dayPrice")]
        public int DayPrice { get; set; }

    }
}
