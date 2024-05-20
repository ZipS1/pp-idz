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
    public partial class AddClientForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            using (DataContext db =  new DataContext(conn))
            {
                Clients client = new Clients
                {
                    Lastname = textBoxLastname.Text,
                    Name = textBoxName.Text,
                    Patronymic = textBoxPatronymic.Text,
                    Phone = textBoxPhone.Text,
                    Address = textBoxAddress.Text,
                    PassportNumber = textBoxPassportNumber.Text,
                };

                db.GetTable<Clients>().InsertOnSubmit(client);
                db.SubmitChanges();
            }

            ClientsForm clientsForm = this.Owner as ClientsForm;
            clientsForm.LoadData();
            clientsForm.Refresh();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
