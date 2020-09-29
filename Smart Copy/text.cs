using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Copy
{
    public partial class text : UserControl
    {
        private OpenFileDialog ofd;
        private String path;
        private List<String> words;
        private String separator;
        private String txt;

        public text()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.path = ofd.FileName;
                //Open file and read all data from text file
                this.label_path.Text = this.path;

            }
            this.txt = System.IO.File.ReadAllText(this.path);
            textBox1.Text = this.txt;
        }

        private void text_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.csv)|*.*";
        }

        //This is For Done Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textSeparator.Text != "")
            {
                this.separator = this.textSeparator.Text;

                this.words = this.txt.Split(separator.ToCharArray()[0]).ToList();
                var parent = this.Parent as Form2;
                parent.DATA = this.words;
                parent.form1.updateDataList(this.words);
                parent.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Separator in Here");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
