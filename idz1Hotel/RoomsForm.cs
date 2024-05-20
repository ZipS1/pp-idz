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
    public partial class RoomsForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (DataContext db = new DataContext(conn))
            {
                roomsGrid.DataSource = db.GetTable<Rooms>().Select(d => new {
                    d.Id,
                    d.Type,
                    d.Comforts,
                    d.DayPrice,
                });

                roomsGrid.Columns["Id"].HeaderText = "Номер комнаты";
                roomsGrid.Columns["Id"].DisplayIndex = 0;

                roomsGrid.Columns["Type"].HeaderText = "Тип комнаты";
                roomsGrid.Columns["Type"].DisplayIndex = 1;

                roomsGrid.Columns["Comforts"].HeaderText = "Условия";
                roomsGrid.Columns["Comforts"].DisplayIndex = 2;

                roomsGrid.Columns["DayPrice"].HeaderText = "Рекомендуемая цена в день";
                roomsGrid.Columns["DayPrice"].DisplayIndex = 3;

                roomsGrid.Refresh();
            }
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonShowClients_Click(object sender, EventArgs e)
        {
            ClientsForm form = new ClientsForm();
            form.Owner = this;
            form.Show();
        }

        private void ShowBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBookingsForm form = new RoomBookingsForm(Convert.ToInt32(roomsGrid.SelectedRows[0].Cells["Id"].Value));
            form.Owner = this;
            form.Show();
        }

        private void roomsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (e.Button == MouseButtons.Right)
                {
                    roomsGrid.ClearSelection();
                    roomsGrid.Rows[e.RowIndex].Selected = true;
                    contextMenuRoom.Show(Cursor.Position.X, Cursor.Position.Y);
                    roomsGrid.Focus();
                }
        }
    }
}
