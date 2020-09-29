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
    public partial class hand : UserControl
    {

        private List<String> words = new List<string>();

        public hand()
        {
            InitializeComponent();
        }

        private void done_Click(object sender, EventArgs e)
        {
            String temp_words = this.hand_text.Text;
            this.words = temp_words.Split(',').ToList();
            var parent = this.Parent as Form2;
            parent.DATA = this.words;
            parent.form1.updateDataList(this.words);
            parent.Hide();
        }
    }
}
