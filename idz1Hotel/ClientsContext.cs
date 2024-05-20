using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idz1Hotel
{
    [Table(Name = "Clients")]
    public class Clients
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "lastname")]
        public string Lastname { get; set; }

        [Column(Name = "name")]
        public string Name { get; set; }

        [Column(Name = "patronymic")]
        public string Patronymic { get; set; }

        [Column(Name = "address")]
        public string Address { get; set; }

        [Column(Name = "phone")]
        public string Phone { get; set; }

        [Column(Name = "passport_number")]
        public string PassportNumber { get; set; }
    }
}
