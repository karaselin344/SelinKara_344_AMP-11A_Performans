using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatgenıslıgı = pictureBox1.Width;
            int ikinciatgenıslıgı = pictureBox2.Width;
            int ucuncuatgenıslıgı = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2 .Left+ rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3 .Left+ rastgele.Next(5, 15);

            if(birinciatgenıslıgı+pictureBox1.Left>=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at yarışı kazandı!!!!");
            }

            if(ikinciatgenıslıgı+pictureBox2.Left>=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı!!!!");
            }

            if(ucuncuatgenıslıgı+pictureBox3.Left>=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı!!!!");
            }
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
