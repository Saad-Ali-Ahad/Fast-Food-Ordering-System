using Fast_Food_Ordering_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;

namespace Fast_Food_Ordering_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();

            addUserControl(uc);
           
        }

        public string UserName { get; set; }
        public string lastname { get; set; }
        public string Address { get; set; }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            UC_Menu uc = new UC_Menu();
            addUserControl(uc);
            nameLabel.Text = "Welcome! " + UserName + " " + lastname;
            addressLabel.Text = Address;
        }

        private void home_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            UC_Cart uc = new UC_Cart();
            addUserControl(uc);
        }

        private void ButtonAboutUs_Click(object sender, EventArgs e)
        {
            UC_AboutUs uc = new UC_AboutUs();
            addUserControl(uc);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            obj.BringToFront();
        }

        private void buttonLocateMe_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            };
        }
    }
}
