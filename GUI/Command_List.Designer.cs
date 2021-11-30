
namespace GUI
{
    partial class Command_List
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
            this.user_list = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Employe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Confirmer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Commande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_list
            // 
            this.user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.Id_Employe,
            this.Confirmer,
            this.Date_Commande,
            this.Prix});
            this.user_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_list.ForeColor = System.Drawing.Color.Black;
            this.user_list.FullRowSelect = true;
            this.user_list.GridLines = true;
            this.user_list.HideSelection = false;
            this.user_list.Location = new System.Drawing.Point(62, 67);
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(674, 294);
            this.user_list.TabIndex = 2;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.Details;
            this.user_list.SelectedIndexChanged += new System.EventHandler(this.user_list_SelectedIndexChanged);
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
            this.Confirmer.Width = 78;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Liste Commandes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(743, 86);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(142, 31);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Command_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_list);
            this.Name = "Command_List";
            this.Text = "Command_List";
            this.Load += new System.EventHandler(this.Command_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.ColumnHeader Reference;
        private System.Windows.Forms.ColumnHeader Id_Employe;
        private System.Windows.Forms.ColumnHeader Confirmer;
        private System.Windows.Forms.ColumnHeader Date_Commande;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
    }
}