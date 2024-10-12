using System;
using System.Threading;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        private Thread ThreadA;
        private Thread ThreadB;

        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "-Before Starting Thread-";  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
            ThreadB = new Thread(MyThreadClass.Thread1) { Name = "Thread B" };

            
            ThreadA.Start();
            ThreadB.Start();

            
            ThreadA.Join();
            ThreadB.Join();

            
            lblStatus.Text = "-End of Thread-";
        }
    }
}
