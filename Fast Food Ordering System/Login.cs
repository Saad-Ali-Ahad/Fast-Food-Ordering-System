using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Fast_Food_Ordering_System;
using Fast_Food_Ordering_System.UserControls;
using Bunifu.Framework.UI;

namespace Login_form
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void PnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

            SignUp obj = new SignUp();
            obj.Show();
            obj.BringToFront();

            /*PnlRegister.Height = PnlMain.Height;
            PnlMain.Location = new Point(5,5);
            
            
            
            Pnl.Location = new Point(310,3);
            */
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(395, 3);
            Pnl.Location= new Point(5,5);
        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(394, 5);
            Pnl.Location = new Point(5,5);
        }
        public static bool IsUserLoggedIn { get; private set; } = false;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TextUserName.Text != "" && TextPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from signup where email=@email and pass =@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", TextUserName.Text);
                cmd.Parameters.AddWithValue("@pass", TextPassword.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    int nameIndex = dr.GetOrdinal("firstname"); // Retrieve the index of the "name" column
                    int lastIndex = dr.GetOrdinal("lastname");
                    int addressIndex = dr.GetOrdinal("homeaddress"); // Retrieve the index of the "address" column

                    while (dr.Read())
                    {
                        string name = dr.GetString(nameIndex);
                        string last = dr.GetString(lastIndex);
                        string address = dr.GetString(addressIndex);


                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsUserLoggedIn = true;
                    this.Hide(); // Hide the Login form

                       
                        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                        if (form1 != null)
                        {
                            form1.UserName = name;
                            form1.lastname = last;
                            form1.Address = address;
                        }

                        UC_Menu obj = new UC_Menu();
                       
                        obj.Show();
                        obj.BringToFront();
                        

                }

                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill both fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {
          

        }

        private void TextUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextUserName.Text) == true)
            {
                TextUserName.Focus();
                errorProvider1.SetError(this.TextUserName, "Please fill this field!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {

        }

        private void TextUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
          
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
        }

        private void gunaCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged_2(object sender, EventArgs e)
        {
          
        }
    }
}
