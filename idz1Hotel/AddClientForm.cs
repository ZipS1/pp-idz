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
        int clientId;

        public AddClientForm(int clientId = -1)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void LoadData()
        {
            using (DataContext db = new DataContext(conn))
            {
                if (clientId != -1)
                {
                    Clients client = db.GetTable<Clients>().FirstOrDefault(c => c.Id == clientId);
                    textBoxLastname.Text = client.Lastname;
                    textBoxName.Text = client.Name;
                    textBoxPatronymic.Text = client.Patronymic;
                    textBoxPhone.Text = client.Phone;
                    textBoxPassportNumber.Text = client.PassportNumber;
                    textBoxAddress.Text = client.Address;
                }
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            using (DataContext db =  new DataContext(conn))
            {
                if (clientId != 1)
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
                else
                {
                    Clients client = db.GetTable<Clients>().FirstOrDefault(c => c.Id == clientId);
                    client.Lastname = textBoxLastname.Text;
                    client.Name = textBoxName.Text;
                    client.Patronymic = textBoxPatronymic.Text;
                    client.Phone = textBoxPhone.Text;
                    client.Address = textBoxAddress.Text;
                    client.PassportNumber = textBoxPassportNumber.Text;
                    db.SubmitChanges();
                }
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

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
