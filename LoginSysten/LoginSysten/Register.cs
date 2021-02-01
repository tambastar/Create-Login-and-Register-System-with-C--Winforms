using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSysten
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            // pass the database you want to connect to
            db.Connect("userdata");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // saves data in the database
            db.Execute("INSERT INTO `user_info` (`id`, `names`, `username`, `password`) VALUES (NULL, '"+textBox3.Text+"', '"+textBox1.Text+"', '"+textBox2.Text+"');");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // closses the register window
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // start login window
            Form1 login  = new Form1();

            login.Show();
        }
    }
}
