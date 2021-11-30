
namespace GUI.MenuStrip
{
    partial class Type_Boisson
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
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypeBoisson = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtEmballage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(170, 197);
            this.txtCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(195, 35);
            this.txtCategorie.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categories";
            // 
            // txtTypeBoisson
            // 
            this.txtTypeBoisson.Font = new System.Drawing.Font("Arial", 18F);
            this.txtTypeBoisson.Location = new System.Drawing.Point(170, 47);
            this.txtTypeBoisson.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeBoisson.Name = "txtTypeBoisson";
            this.txtTypeBoisson.Size = new System.Drawing.Size(195, 35);
            this.txtTypeBoisson.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(28, 54);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 26);
            this.label.TabIndex = 12;
            this.label.Text = "Id Type";
            // 
            // txtEmballage
            // 
            this.txtEmballage.Font = new System.Drawing.Font("Arial", 18F);
            this.txtEmballage.Location = new System.Drawing.Point(170, 147);
            this.txtEmballage.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmballage.Name = "txtEmballage";
            this.txtEmballage.Size = new System.Drawing.Size(195, 35);
            this.txtEmballage.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Emballage";
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Arial", 18F);
            this.Type.Location = new System.Drawing.Point(170, 95);
            this.Type.Margin = new System.Windows.Forms.Padding(2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(195, 35);
            this.Type.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type";
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(241, 279);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(98, 32);
            this.Modifier.TabIndex = 21;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCheck.Location = new System.Drawing.Point(64, 249);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(275, 25);
            this.deleteCheck.TabIndex = 20;
            this.deleteCheck.Text = "Cocher si vous voulez supprimer";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(33, 279);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 32);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Type_Boisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTypeBoisson);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtEmballage);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Type_Boisson";
            this.Text = "Type_Boisson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypeBoisson;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtEmballage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.Button Save;
    }
}