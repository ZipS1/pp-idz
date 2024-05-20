namespace idz1Hotel
{
    partial class AddBookingForm
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
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.CheckInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClientsBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCheckInDate
            // 
            this.labelCheckInDate.AutoSize = true;
            this.labelCheckInDate.Location = new System.Drawing.Point(13, 13);
            this.labelCheckInDate.Name = "labelCheckInDate";
            this.labelCheckInDate.Size = new System.Drawing.Size(91, 16);
            this.labelCheckInDate.TabIndex = 0;
            this.labelCheckInDate.Text = "Дата въезда";
            // 
            // CheckInDatePicker
            // 
            this.CheckInDatePicker.Location = new System.Drawing.Point(193, 13);
            this.CheckInDatePicker.Name = "CheckInDatePicker";
            this.CheckInDatePicker.Size = new System.Drawing.Size(200, 22);
            this.CheckInDatePicker.TabIndex = 1;
            // 
            // CheckOutDatePicker
            // 
            this.CheckOutDatePicker.Location = new System.Drawing.Point(193, 41);
            this.CheckOutDatePicker.Name = "CheckOutDatePicker";
            this.CheckOutDatePicker.Size = new System.Drawing.Size(200, 22);
            this.CheckOutDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата въезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Клиент";
            // 
            // PriceUpDown
            // 
            this.PriceUpDown.Location = new System.Drawing.Point(193, 69);
            this.PriceUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PriceUpDown.Name = "PriceUpDown";
            this.PriceUpDown.Size = new System.Drawing.Size(200, 22);
            this.PriceUpDown.TabIndex = 6;
            // 
            // ClientsBox
            // 
            this.ClientsBox.DropDownWidth = 300;
            this.ClientsBox.FormattingEnabled = true;
            this.ClientsBox.Location = new System.Drawing.Point(193, 98);
            this.ClientsBox.Name = "ClientsBox";
            this.ClientsBox.Size = new System.Drawing.Size(200, 24);
            this.ClientsBox.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(297, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 31);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.Location = new System.Drawing.Point(16, 129);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(95, 31);
            this.buttonAddBooking.TabIndex = 9;
            this.buttonAddBooking.Text = "Добавить";
            this.buttonAddBooking.UseVisualStyleBackColor = true;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddBooking);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ClientsBox);
            this.Controls.Add(this.PriceUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckOutDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckInDatePicker);
            this.Controls.Add(this.labelCheckInDate);
            this.Name = "AddBookingForm";
            this.Text = "Добавление брони в комнату";
            this.Load += new System.EventHandler(this.AddBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.DateTimePicker CheckInDatePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PriceUpDown;
        private System.Windows.Forms.ComboBox ClientsBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddBooking;
    }
}