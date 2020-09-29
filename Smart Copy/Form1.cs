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
    public partial class Form1 : Form
    {
        public String[] identifiers_list = new string[2];
        public List<List<String>> words_list = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
            //default  value for identifiers 
            identifiers_list[0] = "<<";
            identifiers_list[1] = ">>";


        }

        //This function for Done Statement
        private void button3_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<string>();
            bool exceptionOrNot = false;
            if (words_list.Count != 0)
            {

                int num_of_list = words_list.Count;
                int size_of_list = words_list[0].Count;
                int i = 0;
                int count = 0;
                while (i < num_of_list)
                {

                    try
                    {
                        temp.Add(words_list[i][count]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Your entered data lenght are not equals");
                        exceptionOrNot = true;
                        words_list = new List<List<string>>();
                        label1.Text = "0";
                        break;
                    }
                    if (count + 1 == size_of_list && i + 1 == num_of_list)
                    {
                        break;
                    }

                    if (i == num_of_list - 1)
                    {
                        i = 0;
                        count++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (!exceptionOrNot)
            {
                Form3 form = new Form3(this.textBox1.Text,this.identifiers_list[0],this.identifiers_list[1],temp);
                form.Show();
                this.Hide();
            }
        }

        private void identifiers_Click(object sender, EventArgs e)
        {
            IDE ide = new IDE(this);
            ide.Show();
        }

        private void data_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                MessageBox.Show("Hellooooooooooooo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
              //  MessageBox.Show(Control.ModifierKeys.ToString);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // MessageBox.Show(Form.ModifierKeys);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 new_form = new Form1();
            new_form.Show();
        }

        public void updateDataList(List<String> word)
        {
            this.words_list.Add(word);
            this.label1.Text = this.words_list.Count.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
