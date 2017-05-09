using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int type;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 0){
                new Dice().Show();
            }
            else{
                new Cards().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit?",
                                                    "Quit",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                Close();
            };
        }
    }
}
