using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trivia_game_4
{
    public partial class Form3 : Form
    {
        public static string fk_ad;
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb;

            ReturnClass rc = new ReturnClass();
            userdb = rc.scalarReturn("select count(ad_id) from admin_athu where ad_user=" + user + " ' ");

            if (userdb != null)
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select ad_password from admin_athu where ad_user=" + user + " ' ");

                if (passworddb.Equals(password))
                {
                    fk_ad = rc.scalarReturn("select ad_id from admin_athu where ad_user='" + user + " ' ");

                    Form2 f = new Form2();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }
            }
    }
}
