using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public enum Russlovar { cat, window, three, kitchen, rainbow}
        //public enum Engslovar { }
        private void button1_Click(object sender, EventArgs e)
        {

            string word;
            bool search = false;
            string res="";
            string[] slovar = new string[10] {"window","окно", "home","дом","cat","кот","sun","солнце" ,"three","дерево"};
            word = textBox1.Text;
            for (int i = 0; i<10 ; i++)
            {
                if (word == slovar[i]) { if (i % 2 == 0) {res = slovar[i + 1]; search=true;} else {res = slovar[i - 1];} }
            }
            if (search == false) res = "слова в словаре нет";
            textBox1.Text = "" + res;

        }
    }
}
