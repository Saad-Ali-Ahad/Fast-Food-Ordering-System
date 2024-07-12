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

namespace Fast_Food_Ordering_System.UserControls
{
    public partial class UC_Cart : UserControl
    {
        public UC_Cart()
        {
            InitializeComponent();
        }

        private void UC_Cart_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for writing a review about us");
            richTextBox1.Clear();
        }
    }
}
