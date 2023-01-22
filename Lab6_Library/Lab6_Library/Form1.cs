using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Library
{
    public partial class Form1 : Form
    {
        Dictionary<string, Book> librarydic = new Dictionary<string, Book>();
        public Form1()
        {
            InitializeComponent();
            Book book1 = new Book("1234BN", "Moby Dick");
            Book book2 = new Book("5647BN", "Ullysses");
            //add them in the Dictionary using the ISBN as Key

            librarydic[book1.ISBN] = book1;
            librarydic[book2.ISBN] = book2;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Book book3 = new Book(textBox1.Text, textBox2.Text);
            librarydic.Add(textBox1.Text, book3);
            librarydic[book3.ISBN] = book3;

            textBox1.Text = "";
            textBox2.Text = "";

            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var item in librarydic)
            {
                //add to the ListBox

                listBox1.Items.Add(item.Value.ISBN);
                listBox3.Items.Add(item.Value.Title);
                listBox4.Items.Add(item.Value.Onloan);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            librarydic.Remove(textBox3.Text);
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var item in librarydic)
            {
                //add to the ListBox

                listBox1.Items.Add(item.Value.ISBN);
                listBox3.Items.Add(item.Value.Title);
                listBox4.Items.Add(item.Value.Onloan);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var item in librarydic)
            {
                //add to the ListBox

                listBox1.Items.Add(item.Value.ISBN);
                listBox3.Items.Add(item.Value.Title);
                listBox4.Items.Add(item.Value.Onloan);
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            librarydic[text].Onloan = true;

            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            foreach (var item in librarydic)
            {

                listBox1.Items.Add(item.Value.ISBN);
                listBox3.Items.Add(item.Value.Title);
                listBox4.Items.Add(item.Value.Onloan);
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            librarydic[text].Onloan = false;
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var item in librarydic)
            {
                //add to the ListBox
                listBox1.Items.Add(item.Value.ISBN);
                listBox3.Items.Add(item.Value.Title);
                listBox4.Items.Add(item.Value.Onloan);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (librarydic.ContainsKey(textBox4.Text))
            {
                listBox2.Items.Add("Title: " + librarydic[textBox4.Text].Title + ", ISBN: " + librarydic[textBox4.Text].ISBN + ", Onloan: " + librarydic[textBox4.Text].Onloan);

            }
            else
            {
                foreach (var item in librarydic)
                {             
                    if (item.Value.Title.Contains(textBox4.Text))
                    {
                        listBox2.Items.Add("Title: " + item.Value.Title + ", ISBN: " + item.Value.ISBN + ", Onloan: " + item.Value.Onloan);
                    }
                }
            }
        }
    }
}
