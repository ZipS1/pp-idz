namespace idz1Hotel
{
    partial class ClientsForm
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
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.contextMenuRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.contextMenuRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            this.clientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Location = new System.Drawing.Point(13, 13);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersWidth = 51;
            this.clientsGrid.RowTemplate.Height = 24;
            this.clientsGrid.Size = new System.Drawing.Size(885, 297);
            this.clientsGrid.TabIndex = 0;
            this.clientsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientsGrid_CellMouseDown);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(13, 316);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(114, 38);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // contextMenuRemove
            // 
            this.contextMenuRemove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMenuItem});
            this.contextMenuRemove.Name = "contextMenuRemove";
            this.contextMenuRemove.Size = new System.Drawing.Size(211, 56);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeMenuItem.Text = "Удалить";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.clientsGrid);
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.contextMenuRemove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuRemove;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
    }
}