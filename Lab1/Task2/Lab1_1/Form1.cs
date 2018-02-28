using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class Form1 : Form
    {

        List<int> MyCollection = new List<int>() { };
        List<string> MyDisplayCollection = new List<string>() { };
        Random rnd = new Random();
        public delegate List<int> Comparator(List<int> collection);

        Comparator greater = new Comparator(greaterMethod);
        Comparator lesser = new Comparator(lesserMethod);

        public static List<int> greaterMethod(List<int> collection)
        {
            collection = collection.OrderBy(o => o).ToList();
            return collection;
        }

        public static List<int> lesserMethod(List<int> collection)
        {
            collection = collection.OrderByDescending(o => o).ToList();
            return collection;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {          
            int collectionSize = int.Parse(this.textBox1.Text);
            for(int i=0; i <= collectionSize; i++)
            {
                MyCollection.Add(rnd.Next(100));
                MyDisplayCollection.Add("ID:" + MyCollection[i].ToString());
            }
            this.listBox1.DataSource = MyDisplayCollection;
            this.listBox2.DataSource = MyDisplayCollection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCollection = greater(MyCollection);
            this.listBox1.DataSource = MyCollection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCollection = lesser(MyCollection);

            this.listBox2.DataSource = MyCollection;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> querryTwo = (from i in MyCollection
                                   where i > 50
                                   select i).ToList();

            this.listBox3.DataSource = querryTwo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> querryTwo = (from i in MyCollection
                                   where i < 50
                                   select i).ToList();

            this.listBox4.DataSource = querryTwo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> querryThree = (from i in MyCollection
                                   where i == 0
                                   select i).ToList();

            this.listBox5.DataSource = querryThree;
        }
    }
}
