﻿using System;
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
    public partial class Form3 : Form
    {
        private String ide_01;
        private String ide_02;
        private String data;
        private Code code;
        private List<String> list;
        public Form3(String data,String ide_01,String ide_02, List<String> list)
        {
            InitializeComponent();
           // this.ControlBox = false;
            this.ide_01 = ide_01;
            this.ide_02 = ide_02;
            this.data = data;
            this.list = list;
            this.code = new Code(this.data,this.ide_01,this.ide_02,this.list);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(code.ClickOnCopy());
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
    
}
