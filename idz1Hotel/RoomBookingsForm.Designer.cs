namespace idz1Hotel
{
    partial class RoomBookingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomBookingsGrid = new System.Windows.Forms.DataGridView();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBookingsGrid
            // 
            this.roomBookingsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomBookingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomBookingsGrid.Location = new System.Drawing.Point(12, 12);
            this.roomBookingsGrid.Name = "roomBookingsGrid";
            this.roomBookingsGrid.RowHeadersWidth = 51;
            this.roomBookingsGrid.RowTemplate.Height = 24;
            this.roomBookingsGrid.Size = new System.Drawing.Size(776, 262);
            this.roomBookingsGrid.TabIndex = 0;
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.Location = new System.Drawing.Point(13, 281);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(163, 44);
            this.buttonAddBooking.TabIndex = 1;
            this.buttonAddBooking.Text = "Добавить";
            this.buttonAddBooking.UseVisualStyleBackColor = true;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // RoomBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddBooking);
            this.Controls.Add(this.roomBookingsGrid);
            this.Name = "RoomBookingsForm";
            this.Text = "Бронирования комнаты";
            this.Load += new System.EventHandler(this.RoomBookingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomBookingsGrid;
        private System.Windows.Forms.Button buttonAddBooking;
    }
}