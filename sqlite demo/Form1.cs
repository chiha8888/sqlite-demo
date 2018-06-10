using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlite_demo
{
    public partial class Form1 : Form
    {
        SqlAccess sqlAccess=new SqlAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sqlAccess.insert(textBox1.Text)==false)
                MessageBox.Show("insert failure.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c=sqlAccess.count(textBox1.Text);
            MessageBox.Show(c.ToString()+"個");
        }
    }
}
