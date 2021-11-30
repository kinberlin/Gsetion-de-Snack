
namespace GUI.SubForms
{
    partial class Bill
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
            this.lblReductions = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Prix_vente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.user_list = new System.Windows.Forms.ListView();
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom_Client = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Commande_No = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReductions
            // 
            this.lblReductions.AutoSize = true;
            this.lblReductions.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReductions.Location = new System.Drawing.Point(512, 327);
            this.lblReductions.Name = "lblReductions";
            this.lblReductions.Size = new System.Drawing.Size(24, 15);
            this.lblReductions.TabIndex = 48;
            this.lblReductions.Text = "Red";
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(433, 345);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(82, 26);
            this.Montant.TabIndex = 44;
            this.Montant.Text = "Montant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "Total :";
            // 
            // Prix_vente
            // 
            this.Prix_vente.Text = "P.U";
            this.Prix_vente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prix_vente.Width = 98;
            // 
            // Quantites
            // 
            this.Quantites.Text = "Quantites";
            this.Quantites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantites.Width = 109;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Reduction en % :";
            // 
            // user_list
            // 
            this.user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Quantites,
            this.Prix_vente,
            this.Total});
            this.user_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_list.ForeColor = System.Drawing.Color.Black;
            this.user_list.GridLines = true;
            this.user_list.HideSelection = false;
            this.user_list.Location = new System.Drawing.Point(104, 133);
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(470, 183);
            this.user_list.TabIndex = 42;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.Details;
            this.user_list.SelectedIndexChanged += new System.EventHandler(this.user_list_SelectedIndexChanged);
            // 
            // Total
            // 
            this.Total.Text = "P.T";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 81;
            // 
            // Nom_Client
            // 
            this.Nom_Client.AutoSize = true;
            this.Nom_Client.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Client.Location = new System.Drawing.Point(99, 85);
            this.Nom_Client.Name = "Nom_Client";
            this.Nom_Client.Size = new System.Drawing.Size(56, 28);
            this.Nom_Client.TabIndex = 41;
            this.Nom_Client.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Client :";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(471, 26);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 24);
            this.Date.TabIndex = 39;
            this.Date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Le :";
            // 
            // Commande_No
            // 
            this.Commande_No.AutoSize = true;
            this.Commande_No.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commande_No.Location = new System.Drawing.Point(321, 54);
            this.Commande_No.Name = "Commande_No";
            this.Commande_No.Size = new System.Drawing.Size(115, 28);
            this.Commande_No.TabIndex = 35;
            this.Commande_No.Text = "Facture No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Facture No. ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 49;
            this.button1.Text = "Generer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblReductions);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.Nom_Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Commande_No);
            this.Controls.Add(this.label6);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReductions;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Prix_vente;
        private System.Windows.Forms.ColumnHeader Quantites;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.Label Nom_Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Commande_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button button1;
    }
}