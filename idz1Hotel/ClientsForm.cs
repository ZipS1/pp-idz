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
    public partial class ClientsForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;

        public ClientsForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            using (DataContext db = new DataContext(conn))
            {
                clientsGrid.DataSource = db.GetTable<Clients>().Select( d => new {
                    d.Id,
                    FullName = d.Lastname + " " + d.Name + " " + d.Patronymic,
                    d.Phone,
                    d.Address,
                    d.PassportNumber,
                });

                clientsGrid.Columns["Id"].Visible = false;
                clientsGrid.Columns["Id"].DisplayIndex = 0;

                clientsGrid.Columns["FullName"].HeaderText = "ФИО";
                clientsGrid.Columns["FullName"].DisplayIndex = 1;

                clientsGrid.Columns["Phone"].HeaderText = "Телефон";
                clientsGrid.Columns["Phone"].DisplayIndex = 2;

                clientsGrid.Columns["Address"].HeaderText = "Адрес";
                clientsGrid.Columns["Address"].DisplayIndex = 3;

                clientsGrid.Columns["PassportNumber"].HeaderText = "Серия и номер паспорта";
                clientsGrid.Columns["PassportNumber"].DisplayIndex = 4;

                clientsGrid.Refresh();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm();
            form.Owner = this;
            form.Show();
        }

        private void clientsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clientsGrid.ClearSelection();
                clientsGrid.Rows[e.RowIndex].Selected = true;
                contextMenuRemove.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(clientsGrid.SelectedRows[0].Cells["Id"].Value);

            using (DataContext db = new DataContext(conn))
            {
                Clients clientToRemove = db.GetTable<Clients>().Where(c => c.Id == clientId).First();
                db.GetTable<Clients>().DeleteOnSubmit(clientToRemove);
                db.SubmitChanges();
            }

            LoadData();
            Refresh();
            contextMenuRemove.Close();
        }
    }
}
