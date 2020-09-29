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
    public partial class csv : UserControl
    {
        private OpenFileDialog ofd;
        private List<String> words = new List<string>();
        private String path = "";

        public csv()
        {
            InitializeComponent();
        }

        private void open_dialog_file_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.path = ofd.FileName;
                url_label.Text = this.path;
                //Open file and read all data from text file


            }
            string text = System.IO.File.ReadAllText(this.path);
            this.words = text.Split(',').ToList();
            foreach (String s in this.words)
            {
                textBox1.Text=textBox1.Text + s+ " , ";
            }
        }

        private void csv_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.csv)|*.*";

        }

        private void done_Click(object sender, EventArgs e)
        {

            var parent = this.Parent as Form2;
            parent.DATA = this.words;
            parent.form1.updateDataList(this.words);
            parent.Hide();
        }
    }
}
