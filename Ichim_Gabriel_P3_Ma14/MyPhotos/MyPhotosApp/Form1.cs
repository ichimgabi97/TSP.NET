using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            API a = new API();
            if(comboBox1.Text != null && textBox1 != null && textBox7.Text != null)
                a.AddTables(comboBox1.Text, textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // test pentru cautarea dupa nume 
            API a = new API();
            pictureBox1.Image = Image.FromFile(a.SearchElementByName(comboBox1.Text, textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            API a = new API();
            a.ModifyElementName(comboBox1.Text, textBox1.Text, textBox8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            API a = new API();
            a.DeleteElement(a.ReturnIdOfElement(textBox7.Text), comboBox1.Text);
        }
    }
}
