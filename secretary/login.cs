using Form_client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretary
{
    public partial class login : Form
    {
        DataBase dataBase = new DataBase();
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pas_textBox2.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pas_textBox2.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            var loginUser = login_textBox1.Text;
            var passUser = pas_textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            
                if (loginUser == "secret" && passUser == "secret") 
                {
                    MessageBox.Show("Access granted for secretary!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    secret Form5 = new secret(); 
                    this.Hide();
                    Form5.ShowDialog(); 
                }
                else if (loginUser == "admin" && passUser == "admin")
                {

                    MessageBox.Show("Access granted for admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    admin Form4 = new admin(); 
                    this.Hide();
                    Form4.ShowDialog(); 
                }
                
                
            
            else
            {
                MessageBox.Show("Account does not exist", "Account doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }
        }
    }
}
