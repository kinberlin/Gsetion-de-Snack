
namespace Formulaires.Formulaires_Strip
{
    partial class Ajout_TYPE_BOISSON
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.Emballage = new System.Windows.Forms.TextBox();
            this.Categorie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de Boisson :";
            this.toolTip1.SetToolTip(this.label1, "ex : Alcoholique, Gazeux etc");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorie :";
            this.toolTip1.SetToolTip(this.label2, "ex: Vin, Beer, Jus");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emballage :";
            this.toolTip1.SetToolTip(this.label3, "ex: bouteille, cannette etc...");
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(180, 27);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(178, 23);
            this.Type.TabIndex = 3;
            // 
            // Emballage
            // 
            this.Emballage.Location = new System.Drawing.Point(180, 92);
            this.Emballage.Name = "Emballage";
            this.Emballage.Size = new System.Drawing.Size(178, 23);
            this.Emballage.TabIndex = 4;
            // 
            // Categorie
            // 
            this.Categorie.Location = new System.Drawing.Point(180, 61);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(178, 23);
            this.Categorie.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Creer ce type de Booisson";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ajout_TYPE_BOISSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.Emballage);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_TYPE_BOISSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout_TYPE_BOISSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Emballage;
        private System.Windows.Forms.TextBox Categorie;
        private System.Windows.Forms.Button button1;
    }
}