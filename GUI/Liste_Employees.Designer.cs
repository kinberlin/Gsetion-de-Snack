
namespace GUI
{
    partial class Liste_Employees
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
            this.Id_Employe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Fonction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_User = new System.Windows.Forms.Button();
            this.Del_User = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_list
            // 
            this.user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Employe,
            this.Nom,
            this.Prenom,
            this.Id_Fonction,
            this.Email});
            this.user_list.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_list.ForeColor = System.Drawing.Color.Black;
            this.user_list.FullRowSelect = true;
            this.user_list.GridLines = true;
            this.user_list.HideSelection = false;
            this.user_list.Location = new System.Drawing.Point(12, 143);
            this.user_list.MultiSelect = false;
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(776, 304);
            this.user_list.TabIndex = 20;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.Details;
            this.user_list.SelectedIndexChanged += new System.EventHandler(this.user_list_SelectedIndexChanged);
            // 
            // Id_Employe
            // 
            this.Id_Employe.Text = "Id";
            this.Id_Employe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 203;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenom.Width = 229;
            // 
            // Id_Fonction
            // 
            this.Id_Fonction.Text = "Id Fonction";
            this.Id_Fonction.Width = 94;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 230;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(484, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Recherchez un employee a afficher en entrant son nom dans la barre de recherche.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_User
            // 
            this.Add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_User.Location = new System.Drawing.Point(717, 102);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(71, 35);
            this.Add_User.TabIndex = 23;
            this.Add_User.Text = "+";
            this.Add_User.UseVisualStyleBackColor = true;
            this.Add_User.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // Del_User
            // 
            this.Del_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_User.Location = new System.Drawing.Point(794, 234);
            this.Del_User.Name = "Del_User";
            this.Del_User.Size = new System.Drawing.Size(122, 35);
            this.Del_User.TabIndex = 24;
            this.Del_User.Text = "Supprimer";
            this.Del_User.UseVisualStyleBackColor = true;
            this.Del_User.Click += new System.EventHandler(this.Del_User_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(794, 182);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(122, 35);
            this.Modifier.TabIndex = 25;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // Liste_Employees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 497);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Del_User);
            this.Controls.Add(this.Add_User);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Name = "Liste_Employees";
            this.Text = "Liste_Employees";
            this.Load += new System.EventHandler(this.Liste_Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Id_Fonction;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Id_Employe;
        private System.Windows.Forms.Button Add_User;
        private System.Windows.Forms.Button Del_User;
        private System.Windows.Forms.Button Modifier;
    }
}