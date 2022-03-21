using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jawaban_Praktikum
{
    public partial class FormMateri : Form
    {
        //ListBox listBoxKoleksi = new ListBox();
        public FormMateri()
        {
            InitializeComponent();
        }

        private void FormMateri_Load(object sender, EventArgs e)
        {

        }

        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (listBoxKoleksi.Items.Contains(textBoxData.Text))
            {
                MessageBox.Show("Error, Ada Data yang sama");
            }
            else
            {
                listBoxKoleksi.Items.Add(textBoxData.Text);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxWarna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarna.Checked == true)
            {
                if(radioButtonBiru.Checked == true)
                {
                    labelShow.ForeColor = Color.Blue;
                }
                if(radioButtonMerah.Checked == true)
                {
                    labelShow.ForeColor = Color.Red;
                }
            }
            else if(checkBoxWarna.Checked == false)
            {
                labelShow.ForeColor = Color.Black;
            }
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelShow.Text = listBoxKoleksi.SelectedItem.ToString();
            
        }

        
        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarna.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelShow.ForeColor = Color.Blue;
                }
                if (radioButtonMerah.Checked == true)
                {
                    labelShow.ForeColor = Color.Red;
                }
            }
            else if (checkBoxWarna.Checked == false)
            {
                labelShow.ForeColor = Color.Black;
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarna.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelShow.ForeColor = Color.Blue;
                }
                if (radioButtonMerah.Checked == true)
                {
                    labelShow.ForeColor = Color.Red;
                }
            }
            else if (checkBoxWarna.Checked == false)
            {
                labelShow.ForeColor = Color.Black;
            }
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Clear();
            labelShow.Text = "";
            textBoxData.Text = "";
            radioButtonMerah.Checked = true;
        }
    }
}
