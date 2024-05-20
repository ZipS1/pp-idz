namespace idz1Hotel
{
    partial class RoomsForm
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
            this.components = new System.ComponentModel.Container();
            this.roomsGrid = new System.Windows.Forms.DataGridView();
            this.buttonShowClients = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.showBookingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGrid)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsGrid
            // 
            this.roomsGrid.AllowUserToAddRows = false;
            this.roomsGrid.AllowUserToDeleteRows = false;
            this.roomsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsGrid.Location = new System.Drawing.Point(12, 12);
            this.roomsGrid.Name = "roomsGrid";
            this.roomsGrid.ReadOnly = true;
            this.roomsGrid.RowHeadersWidth = 51;
            this.roomsGrid.RowTemplate.Height = 24;
            this.roomsGrid.Size = new System.Drawing.Size(776, 287);
            this.roomsGrid.TabIndex = 0;
            this.roomsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomsGrid_CellMouseDown);
            // 
            // buttonShowClients
            // 
            this.buttonShowClients.Location = new System.Drawing.Point(12, 348);
            this.buttonShowClients.Name = "buttonShowClients";
            this.buttonShowClients.Size = new System.Drawing.Size(160, 37);
            this.buttonShowClients.TabIndex = 1;
            this.buttonShowClients.Text = "Список клиентов";
            this.buttonShowClients.UseVisualStyleBackColor = true;
            this.buttonShowClients.Click += new System.EventHandler(this.buttonShowClients_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingsMenuItem,
            this.removeMenuItem,
            this.EditMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(211, 104);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeMenuItem.Text = "Удалить";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(210, 24);
            this.EditMenuItem.Text = "Изменить";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(12, 305);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(160, 37);
            this.buttonAddRoom.TabIndex = 3;
            this.buttonAddRoom.Text = "Добавить";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // showBookingsMenuItem
            // 
            this.showBookingsMenuItem.Name = "showBookingsMenuItem";
            this.showBookingsMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showBookingsMenuItem.Text = "Просмотр";
            this.showBookingsMenuItem.Click += new System.EventHandler(this.showBookingsMenuItem_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.buttonShowClients);
            this.Controls.Add(this.roomsGrid);
            this.Name = "RoomsForm";
            this.Text = "Комнаты";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsGrid)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomsGrid;
        private System.Windows.Forms.Button buttonShowClients;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.ToolStripMenuItem showBookingsMenuItem;
    }
}