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
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton1.Checked)
            {
                Pig_Game_Form GameForm = new Pig_Game_Form();
                GameForm.Show();
                radioButton1.Checked = false;
            }else if (radioButton2.Checked)
            {
                pigWithTwoDiceForm GameForm = new pigWithTwoDiceForm();
                GameForm.Show();
                radioButton2.Checked = false;
            }
            
                        
        }

    }
}
