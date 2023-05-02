using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace prakt14_queue_
{
    
    public partial class Form1 : Form
    {
        List<People> people = new List<People>();
        Stack<int> st = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
            if(File.Exists("inf.txt"))
            {
                string[] peoplee = File.ReadAllLines("inf.txt");
                foreach(string I in peoplee)
                {
                    string[] info = I.Split(' ');
                    people.Add(new People(info[0], info[1], info[2], int.Parse(info[3]), int.Parse(info[4])));
                }
                foreach(People i in people)
                {
                    listBox2.Items.Add(i.Info());
                }
                foreach(People i in people)
                {
                    listBox3.Items.Add(i.Info());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            Queue q = new Queue();
            for(int i=1;i<=n;i++)
            {
                q.Enqueue(i);
            }
            while(q.Count>0)
            {
                int numb = (int)q.Dequeue();
                listBox1.Items.Add(numb);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var age = from i in people
                      where i.GetAge < 40
                      select i;
            foreach(People i in age)
            {
                listBox2.Items.Add(i.Info());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items
        }
    }
}
