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
    public partial class IDE : Form
    {
        Form1 form;
        public IDE(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ide_01 = textBox1.Text.TrimEnd();
            String ide_02 = textBox2.Text.TrimEnd();
            if (!(ide_01 == "" || ide_02 == "" ))
            {
                if ((ide_01.Length == 2) && (ide_02.Length==2))
                {
                    this.form.identifiers_list[0] = ide_01;
                    this.form.identifiers_list[1] = ide_02;

                }
            }
        }
    }
}
