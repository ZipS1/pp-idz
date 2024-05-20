using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idz1Hotel
{
    public partial class AddBookingForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;
        private int roomId;

        public AddBookingForm(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.Text = $"Добавление брони в комнату #{roomId}";
        }

        private void LoadData()
        {
            this.PriceUpDown.Value = ((RoomsForm)this.Owner.Owner).GetRecommendedPrice(roomId);

            using (DataContext db = new DataContext(conn))
            {
                ClientsBox.DataSource = db.GetTable<Clients>().Select(c => new
                {
                    FullNameAndPhone = c.Lastname + ' ' + c.Name + ' ' + c.Patronymic + " (" + c.Phone + ')',
                }).Select(c => c.FullNameAndPhone);
        }
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            string clientNameAndPhone = ClientsBox.SelectedValue as string;
            string[] tokens = clientNameAndPhone.Split(' ');
            string lastname = tokens[0];
            string name = tokens[1];
            string patronymic = tokens[2];
            string phone = tokens[3].Trim('(', ')');

            using (DataContext db = new DataContext(conn))
            {
                Bookings booking = new Bookings
                {
                    RoomId = roomId,
                    CheckInDate = CheckInDatePicker.Value,
                    CheckOutDate = CheckOutDatePicker.Value,
                    Price = (int)PriceUpDown.Value,
                    ClientId = db.GetTable<Clients>().Select(c => new
                    {
                        c.Id,
                        c.Lastname,
                        c.Name,
                        c.Patronymic,
                        c.Phone,
                    })
                    .Where(c =>
                        c.Lastname == lastname &&
                        c.Name == name &&
                        c.Patronymic == patronymic &&
                        c.Phone == phone
                    ).Select(c => c.Id).First()
                };

                db.GetTable<Bookings>().InsertOnSubmit(booking);
                db.SubmitChanges();
            }

            RoomBookingsForm form = this.Owner as RoomBookingsForm;
            form.LoadData();
            form.Refresh();
            this.Close();
        }
    }
}
