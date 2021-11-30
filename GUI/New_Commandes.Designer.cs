
namespace GUI
{
    partial class New_Commandes
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
            this.txtNM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_list = new System.Windows.Forms.ListView();
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix_vente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.Quantite = new System.Windows.Forms.TextBox();
            this.list_Pro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commander = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.idCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNM
            // 
            this.txtNM.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNM.Location = new System.Drawing.Point(261, 53);
            this.txtNM.Name = "txtNM";
            this.txtNM.Size = new System.Drawing.Size(380, 30);
            this.txtNM.TabIndex = 1;
            this.txtNM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Boisson : ";
            // 
            // pro_list
            // 
            this.pro_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marque,
            this.Nom,
            this.Quantites,
            this.Prix_vente,
            this.Id_type});
            this.pro_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_list.ForeColor = System.Drawing.Color.Black;
            this.pro_list.FullRowSelect = true;
            this.pro_list.GridLines = true;
            this.pro_list.HideSelection = false;
            this.pro_list.Location = new System.Drawing.Point(137, 99);
            this.pro_list.MultiSelect = false;
            this.pro_list.Name = "pro_list";
            this.pro_list.Size = new System.Drawing.Size(552, 120);
            this.pro_list.TabIndex = 2;
            this.pro_list.UseCompatibleStateImageBehavior = false;
            this.pro_list.View = System.Windows.Forms.View.Details;
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
            this.Quantites.Text = "En Stock";
            this.Quantites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantites.Width = 78;
            // 
            // Prix_vente
            // 
            this.Prix_vente.Text = "Prix Vente";
            this.Prix_vente.Width = 88;
            // 
            // Id_type
            // 
            this.Id_type.Text = "No type";
            this.Id_type.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantites :";
            // 
            // Quantite
            // 
            this.Quantite.Location = new System.Drawing.Point(113, 233);
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(60, 20);
            this.Quantite.TabIndex = 3;
            // 
            // list_Pro
            // 
            this.list_Pro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_Pro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Pro.ForeColor = System.Drawing.Color.Black;
            this.list_Pro.GridLines = true;
            this.list_Pro.HideSelection = false;
            this.list_Pro.Location = new System.Drawing.Point(52, 268);
            this.list_Pro.Name = "list_Pro";
            this.list_Pro.Size = new System.Drawing.Size(637, 120);
            this.list_Pro.TabIndex = 5;
            this.list_Pro.UseCompatibleStateImageBehavior = false;
            this.list_Pro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marque";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "En Stock";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix Vente";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No type";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantites";
            this.columnHeader6.Width = 86;
            // 
            // Commander
            // 
            this.Commander.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Commander.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commander.Location = new System.Drawing.Point(521, 394);
            this.Commander.Name = "Commander";
            this.Commander.Size = new System.Drawing.Size(144, 34);
            this.Commander.TabIndex = 7;
            this.Commander.Text = "Commander";
            this.Commander.UseVisualStyleBackColor = false;
            this.Commander.Click += new System.EventHandler(this.Commander_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(521, 224);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(134, 33);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(133, 394);
            this.idCombo.Name = "idCombo";
            this.idCombo.Size = new System.Drawing.Size(85, 21);
            this.idCombo.TabIndex = 6;
            this.idCombo.SelectedIndexChanged += new System.EventHandler(this.idCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id Employee :";
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(209, 23);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(258, 20);
            this.Client.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom Client :";
            // 
            // New_Commandes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Commander);
            this.Controls.Add(this.list_Pro);
            this.Controls.Add(this.Quantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pro_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNM);
            this.Name = "New_Commandes";
            this.Text = " ";
            this.Load += new System.EventHandler(this.New_Commandes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView pro_list;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Quantites;
        private System.Windows.Forms.ColumnHeader Prix_vente;
        private System.Windows.Forms.ColumnHeader Id_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Quantite;
        private System.Windows.Forms.ListView list_Pro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button Commander;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.ComboBox idCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}