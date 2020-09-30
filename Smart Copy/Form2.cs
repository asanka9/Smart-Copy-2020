using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Copy
{
    public partial class Form2 : Form
    {
        public String url = "Form 2 data ";
        public List<String> data_list = new List<string>();
        public Form1 form1;

        public Form2(Form1 form)
        {
            InitializeComponent();
            api1.Hide();
            csv1.Hide();
            text1.Hide();
            hand1.Show();
            hand1.BringToFront();
            this.form1 = form;




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    api1.Hide();
                    csv1.Hide();
                    text1.Hide();
                    hand1.Show();
                    hand1.BringToFront();
                    break;
                case 1:
                    csv1.Hide();
                    text1.Hide();
                    hand1.Hide();
                    api1.Show();
                    api1.BringToFront();
                    break;
                case 2:
                    api1.Hide();
                    text1.Hide();
                    csv1.Show();
                    csv1.BringToFront();
                    break;
                case 3:
                    api1.Hide();
                    csv1.Hide();
                    text1.Show();
                    text1.BringToFront();
                    break;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.url);
        }
        public List<String> DATA
        {
            set { this.data_list = value; }
        }

    }
}
