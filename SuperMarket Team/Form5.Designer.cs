
namespace SuperMarket_Team
{
    partial class SuperMarket
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Browsing_Product = new System.Windows.Forms.Button();
            this.Show_Products = new System.Windows.Forms.Button();
            this.Customer_Details = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelToolbar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(764, 382);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.panelToolbar.Controls.Add(this.button4);
            this.panelToolbar.Controls.Add(this.button3);
            this.panelToolbar.Controls.Add(this.button2);
            this.panelToolbar.Controls.Add(this.button1);
            this.panelToolbar.Controls.Add(this.lbltitle);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(220, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(764, 80);
            this.panelToolbar.TabIndex = 4;
            this.panelToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(347, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(109, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Welcome";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.panelMenu.Controls.Add(this.BackButton);
            this.panelMenu.Controls.Add(this.Browsing_Product);
            this.panelMenu.Controls.Add(this.Show_Products);
            this.panelMenu.Controls.Add(this.Customer_Details);
            this.panelMenu.Controls.Add(this.panelAdmin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 462);
            this.panelMenu.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.Snow;
            this.BackButton.Location = new System.Drawing.Point(0, 260);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(220, 60);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Browsing_Product
            // 
            this.Browsing_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.Browsing_Product.FlatAppearance.BorderSize = 0;
            this.Browsing_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browsing_Product.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.Browsing_Product.ForeColor = System.Drawing.Color.Snow;
            this.Browsing_Product.Location = new System.Drawing.Point(0, 200);
            this.Browsing_Product.Name = "Browsing_Product";
            this.Browsing_Product.Size = new System.Drawing.Size(220, 60);
            this.Browsing_Product.TabIndex = 5;
            this.Browsing_Product.Text = "Browsing product";
            this.Browsing_Product.UseVisualStyleBackColor = true;
            this.Browsing_Product.Click += new System.EventHandler(this.Browsing_Product_Click);
            // 
            // Show_Products
            // 
            this.Show_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.Show_Products.FlatAppearance.BorderSize = 0;
            this.Show_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Products.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.Show_Products.ForeColor = System.Drawing.Color.Snow;
            this.Show_Products.Location = new System.Drawing.Point(0, 140);
            this.Show_Products.Name = "Show_Products";
            this.Show_Products.Size = new System.Drawing.Size(220, 60);
            this.Show_Products.TabIndex = 4;
            this.Show_Products.Text = "Show Products";
            this.Show_Products.UseVisualStyleBackColor = true;
            this.Show_Products.Click += new System.EventHandler(this.Show_Products_Click);
            // 
            // Customer_Details
            // 
            this.Customer_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customer_Details.FlatAppearance.BorderSize = 0;
            this.Customer_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Details.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.Customer_Details.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Details.Location = new System.Drawing.Point(0, 80);
            this.Customer_Details.Name = "Customer_Details";
            this.Customer_Details.Size = new System.Drawing.Size(220, 60);
            this.Customer_Details.TabIndex = 1;
            this.Customer_Details.Text = "Customer Details";
            this.Customer_Details.UseVisualStyleBackColor = true;
            this.Customer_Details.Click += new System.EventHandler(this.Customer_Details_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdmin.ForeColor = System.Drawing.Color.Snow;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(220, 80);
            this.panelAdmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase Project";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(731, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(658, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(694, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SuperMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "SuperMarket";
            this.Text = "SuperMarket";
            this.Load += new System.EventHandler(this.SuperMarket_Load);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Browsing_Product;
        private System.Windows.Forms.Button Show_Products;
        private System.Windows.Forms.Button Customer_Details;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}