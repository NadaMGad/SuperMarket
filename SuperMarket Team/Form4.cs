using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Team
{
    public partial class Form4 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form4()
        {
            InitializeComponent();
            random = new Random();
            button1.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Color SelectThemecolors()
        {
            int index = random.Next(Themecolors.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Themecolors.colorList.Count);
            }
            tempIndex = index;
            string color = Themecolors.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemecolors();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelToolbar.BackColor = color;
                    panelAdmin.BackColor = Themecolors.ChangeColorBrightness(color, -0.3);
                    Themecolors.PrimaryColor = color;
                    Themecolors.SecondaryColor = Themecolors.ChangeColorBrightness(color, -0.3);
                    button1.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }
       

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Customer_Details_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customer_Form(), sender);
        }

        private void Admin_Details_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Form(), sender);
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_Product(), sender);
        }

        private void Show_Products_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Available_Products(), sender);
        }

        private void Browsing_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Browsing_Product(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lbltitle.Text = "Welcome";
            panelToolbar.BackColor = Color.FromArgb(0, 150, 136);
            panelAdmin.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button1.Visible = false;
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_Department(), sender);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.ShowDialog();
            

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParm, int lparm);
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender);
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
           

        }
    }
}
