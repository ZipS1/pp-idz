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
    public partial class AddRoomForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;
        int roomId;

        public AddRoomForm(int roomId = -1)
        {
            this.roomId = roomId;
            InitializeComponent();
        }

        private void LoadData()
        {
            if (roomId != -1)
                buttonAddRoom.Text = "Изменить";

            typeBox.DataSource = new string[] { "одноместный", "двухместный", "трехместный", "четырехместный" };

            if (roomId != -1)
            {
                using (DataContext db = new DataContext(conn))
                {
                    Rooms roomToEdit = db.GetTable<Rooms>().FirstOrDefault(r => r.Id == roomId);
                    typeBox.SelectedIndex = typeBox.FindString(roomToEdit.Type);
                    textBoxComforts.Text = roomToEdit.Comforts;
                    DayPriceUpDown.Value = roomToEdit.DayPrice;
                }
            }
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext(conn))
            {
                if (roomId != -1)
                {
                    Rooms roomToEdit = db.GetTable<Rooms>().FirstOrDefault(r => r.Id == roomId);
                    roomToEdit.Type = typeBox.SelectedValue as string;
                    roomToEdit.Comforts = textBoxComforts.Text;
                    roomToEdit.DayPrice = (int)DayPriceUpDown.Value;
                    db.SubmitChanges();
                }
                else
                {
                    Rooms room = new Rooms
                    {
                        Type = typeBox.SelectedValue as string,
                        Comforts = textBoxComforts.Text,
                        DayPrice = (int)DayPriceUpDown.Value,
                    };

                    db.GetTable<Rooms>().InsertOnSubmit(room);
                    db.SubmitChanges();
                }

                RoomsForm form = this.Owner as RoomsForm;
                form.LoadData();
                form.Refresh();
                this.Close();
            }
        }
    }
}
