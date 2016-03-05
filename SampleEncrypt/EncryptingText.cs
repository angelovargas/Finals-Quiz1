using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleEncrypt
{
    public partial class EncryptingText : Form
    {
        public EncryptingText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(StringBox.Text) && !string.IsNullOrWhiteSpace(StringBox.Text)) == true)
            {
                try
                {
                    EncryptedBox.Text = EncryptClass.EncryptString(StringBox.Text, StringBox.Text);
                    StringBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
