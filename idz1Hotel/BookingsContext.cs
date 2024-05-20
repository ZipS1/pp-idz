using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idz1Hotel
{
    [Table(Name = "Bookings")]
    internal class Bookings
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "room_id")]
        public int RoomId { get; set; }

        [Column(Name = "checkin_date")]
        public DateTime CheckInDate { get; set; }

        [Column(Name = "checkout_date")]
        public DateTime CheckOutDate { get; set; }

        [Column(Name = "price")]
        public int Price { get; set; }

        [Column(Name = "client_id")]
        public int ClientId { get; set; }
    }
}
