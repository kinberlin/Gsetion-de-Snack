
namespace GUI.SubForms
{
    partial class Commande_Boisson
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
            this.Commande_No = new System.Windows.Forms.Label();
            this.Employe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom_Client = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_list = new System.Windows.Forms.ListView();
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix_vente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Montant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CONFIRMER = new System.Windows.Forms.Button();
            this.Reduction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReductions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Commande No. ";
            // 
            // Commande_No
            // 
            this.Commande_No.AutoSize = true;
            this.Commande_No.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commande_No.Location = new System.Drawing.Point(363, 47);
            this.Commande_No.Name = "Commande_No";
            this.Commande_No.Size = new System.Drawing.Size(158, 28);
            this.Commande_No.TabIndex = 19;
            this.Commande_No.Text = "Commande No. ";
            // 
            // Employe
            // 
            this.Employe.AutoSize = true;
            this.Employe.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employe.Location = new System.Drawing.Point(131, 77);
            this.Employe.Name = "Employe";
            this.Employe.Size = new System.Drawing.Size(92, 28);
            this.Employe.TabIndex = 21;
            this.Employe.Text = "Employe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Servir par :";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(549, 19);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 24);
            this.Date.TabIndex = 23;
            this.Date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Le :";
            // 
            // Nom_Client
            // 
            this.Nom_Client.AutoSize = true;
            this.Nom_Client.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Client.Location = new System.Drawing.Point(141, 111);
            this.Nom_Client.Name = "Nom_Client";
            this.Nom_Client.Size = new System.Drawing.Size(56, 28);
            this.Nom_Client.TabIndex = 25;
            this.Nom_Client.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Client :";
            // 
            // user_list
            // 
            this.user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marque,
            this.Nom,
            this.Quantites,
            this.Prix_vente,
            this.Id_type,
            this.Total});
            this.user_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_list.ForeColor = System.Drawing.Color.Black;
            this.user_list.GridLines = true;
            this.user_list.HideSelection = false;
            this.user_list.Location = new System.Drawing.Point(62, 157);
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(613, 183);
            this.user_list.TabIndex = 26;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.Details;
            this.user_list.SelectedIndexChanged += new System.EventHandler(this.user_list_SelectedIndexChanged);
            // 
            // Marque
            // 
            this.Marque.Text = "Marque";
            this.Marque.Width = 126;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 177;
            // 
            // Quantites
            // 
            this.Quantites.Text = "Quantites";
            this.Quantites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantites.Width = 78;
            // 
            // Prix_vente
            // 
            this.Prix_vente.Text = "P.U";
            this.Prix_vente.Width = 75;
            // 
            // Id_type
            // 
            this.Id_type.Text = "No type";
            this.Id_type.Width = 75;
            // 
            // Total
            // 
            this.Total.Text = "P.T";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 73;
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(564, 389);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(89, 28);
            this.Montant.TabIndex = 28;
            this.Montant.Text = "Montant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total :";
            // 
            // CONFIRMER
            // 
            this.CONFIRMER.BackColor = System.Drawing.Color.Lime;
            this.CONFIRMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFIRMER.Location = new System.Drawing.Point(62, 384);
            this.CONFIRMER.Name = "CONFIRMER";
            this.CONFIRMER.Size = new System.Drawing.Size(135, 35);
            this.CONFIRMER.TabIndex = 29;
            this.CONFIRMER.Text = "CONFIRMER";
            this.CONFIRMER.UseVisualStyleBackColor = false;
            this.CONFIRMER.Click += new System.EventHandler(this.CONFIRMER_Click);
            // 
            // Reduction
            // 
            this.Reduction.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reduction.Location = new System.Drawing.Point(569, 353);
            this.Reduction.Name = "Reduction";
            this.Reduction.Size = new System.Drawing.Size(55, 20);
            this.Reduction.TabIndex = 31;
            this.Reduction.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Reduction en % :";
            // 
            // lblReductions
            // 
            this.lblReductions.AutoSize = true;
            this.lblReductions.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReductions.Location = new System.Drawing.Point(565, 356);
            this.lblReductions.Name = "lblReductions";
            this.lblReductions.Size = new System.Drawing.Size(24, 15);
            this.lblReductions.TabIndex = 33;
            this.lblReductions.Text = "Red";
            // 
            // Commande_Boisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 428);
            this.Controls.Add(this.Reduction);
            this.Controls.Add(this.lblReductions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CONFIRMER);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.Nom_Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Employe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Commande_No);
            this.Controls.Add(this.label6);
            this.Name = "Commande_Boisson";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Commande_Boisson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Commande_No;
        private System.Windows.Forms.Label Employe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nom_Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Quantites;
        private System.Windows.Forms.ColumnHeader Prix_vente;
        private System.Windows.Forms.ColumnHeader Id_type;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CONFIRMER;
        private System.Windows.Forms.TextBox Reduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReductions;
    }
}