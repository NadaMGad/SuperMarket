
namespace SuperMarket_Team.Forms
{
    partial class Add_Department
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Product_Name = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(49, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Departement Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 58;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Product_Name.Location = new System.Drawing.Point(49, 102);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(108, 13);
            this.Product_Name.TabIndex = 56;
            this.Product_Name.Text = "Department Name";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(204, 251);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 62;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Product_Name);
            this.Name = "Add_Department";
            this.Text = "Add_Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
    }
}