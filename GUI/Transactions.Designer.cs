
namespace GUI
{
    partial class Transactions
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
            this.label6 = new System.Windows.Forms.Label();
            this.command_list = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Employe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Confirmer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Commande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.receipt_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro Cond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Commandes Recents ...";
            // 
            // command_list
            // 
            this.command_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.Id_Employe,
            this.Confirmer,
            this.Date_Commande,
            this.Prix});
            this.command_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.command_list.ForeColor = System.Drawing.Color.Black;
            this.command_list.GridLines = true;
            this.command_list.HideSelection = false;
            this.command_list.Location = new System.Drawing.Point(62, 45);
            this.command_list.Name = "command_list";
            this.command_list.Size = new System.Drawing.Size(668, 155);
            this.command_list.TabIndex = 21;
            this.command_list.UseCompatibleStateImageBehavior = false;
            this.command_list.View = System.Windows.Forms.View.Details;
            this.command_list.SelectedIndexChanged += new System.EventHandler(this.command_list_SelectedIndexChanged);
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            this.Reference.Width = 146;
            // 
            // Id_Employe
            // 
            this.Id_Employe.Text = "Id Employe";
            this.Id_Employe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id_Employe.Width = 115;
            // 
            // Confirmer
            // 
            this.Confirmer.Text = "Confirmer";
            this.Confirmer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Confirmer.Width = 171;
            // 
            // Date_Commande
            // 
            this.Date_Commande.Text = "Date_Commande";
            this.Date_Commande.Width = 140;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            this.Prix.Width = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Cond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Factures Recents ...";
            // 
            // receipt_list
            // 
            this.receipt_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Client,
            this.Date,
            this.columnHeader5});
            this.receipt_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_list.ForeColor = System.Drawing.Color.Black;
            this.receipt_list.GridLines = true;
            this.receipt_list.HideSelection = false;
            this.receipt_list.Location = new System.Drawing.Point(62, 254);
            this.receipt_list.Name = "receipt_list";
            this.receipt_list.Size = new System.Drawing.Size(668, 176);
            this.receipt_list.TabIndex = 23;
            this.receipt_list.UseCompatibleStateImageBehavior = false;
            this.receipt_list.View = System.Windows.Forms.View.Details;
            this.receipt_list.SelectedIndexChanged += new System.EventHandler(this.receipt_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reference";
            this.columnHeader1.Width = 146;
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Client.Width = 205;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 186;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prix";
            this.columnHeader5.Width = 182;
            // 
            // Transactions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receipt_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.command_list);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView command_list;
        private System.Windows.Forms.ColumnHeader Reference;
        private System.Windows.Forms.ColumnHeader Id_Employe;
        private System.Windows.Forms.ColumnHeader Confirmer;
        private System.Windows.Forms.ColumnHeader Date_Commande;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView receipt_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}