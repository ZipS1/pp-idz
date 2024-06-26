﻿using System;
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
    public partial class RoomBookingsForm : Form
    {
        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["hotelConnectionString"].ConnectionString;
        private int roomId;

        public RoomBookingsForm(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.Text = $"Бронирования комнаты #{roomId}";
        }

        public void LoadData()
        {
            using (DataContext db = new DataContext(conn))
            {
                roomBookingsGrid.DataSource = db.GetTable<Bookings>().Select(d => new
                {
                    d.Id,
                    d.RoomId,
                    d.CheckInDate,
                    d.CheckOutDate,
                    d.ClientId,
                    d.Price,
                    FullName = db.GetTable<Clients>().Select(c => new
                    {
                        c.Id,
                        FullName = c.Lastname + ' ' + c.Name + ' ' + c.Patronymic,
                    }).Where(c => c.Id == d.ClientId).First().FullName
                }).Where(d => d.RoomId == this.roomId);

                roomBookingsGrid.Columns["Id"].Visible = false;
                roomBookingsGrid.Columns["Id"].DisplayIndex = 0;

                roomBookingsGrid.Columns["RoomId"].Visible = false;
                roomBookingsGrid.Columns["RoomId"].DisplayIndex = 1;

                roomBookingsGrid.Columns["CheckInDate"].HeaderText = "Дата въезда";
                roomBookingsGrid.Columns["CheckInDate"].DisplayIndex = 2;

                roomBookingsGrid.Columns["CheckOutDate"].HeaderText = "Дата отъезда";
                roomBookingsGrid.Columns["CheckOutDate"].DisplayIndex = 3;

                roomBookingsGrid.Columns["ClientId"].Visible = false;
                roomBookingsGrid.Columns["ClientId"].DisplayIndex = 4;

                roomBookingsGrid.Columns["FullName"].HeaderText = "ФИО";
                roomBookingsGrid.Columns["FullName"].DisplayIndex = 5;
                roomBookingsGrid.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                roomBookingsGrid.Columns["FullName"].Width = 180;

                roomBookingsGrid.Columns["Price"].HeaderText = "Оплата";
                roomBookingsGrid.Columns["Price"].DisplayIndex = 6;

                roomBookingsGrid.Refresh();
            }
        }

        private void RoomBookingsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            AddBookingForm form = new AddBookingForm(roomId);
            form.Owner = this;
            form.Show();
        }

        private void roomBookingsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                roomBookingsGrid.ClearSelection();
                roomBookingsGrid.Rows[e.RowIndex].Selected = true;
                contextMenuRemove.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            int bookingId = Convert.ToInt32(roomBookingsGrid.SelectedRows[0].Cells["Id"].Value);

            using (DataContext db = new DataContext(conn))
            {
                Bookings bookingToRemove = db.GetTable<Bookings>().Where(b => b.Id == bookingId).First();
                db.GetTable<Bookings>().DeleteOnSubmit(bookingToRemove);
                db.SubmitChanges();
            }

            LoadData();
            Refresh();
            contextMenuRemove.Close();
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingForm form = new AddBookingForm(roomId, Convert.ToInt32(roomBookingsGrid.SelectedRows[0].Cells["Id"].Value));
            form.Owner = this;
            form.Show();
        }
    }
}
