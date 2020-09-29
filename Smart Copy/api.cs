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
    public partial class api : UserControl
    {
        private List<String> words = new List<string>();

        public api()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void done_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;
            parent.DATA = this.words;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
