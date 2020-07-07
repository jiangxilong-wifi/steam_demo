using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Steam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //鼠标悬浮关闭
        private void close_gray_MouseEnter(object sender, EventArgs e)
        {
            //切换到图片列表2
            close.Image = imageList1.Images[1];
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //图片列表1
            close.Image = imageList1.Images[0];
            //图片列表2
            mini.Image = imageList2.Images[0];
        }

        //鼠标离开
        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            //close.Image = imageList1.Images[0];
        }

        //鼠标点击关闭
        private void close_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        //鼠标点击最小化
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //鼠标悬浮最小化
        private void mini_MouseEnter(object sender, EventArgs e)
        {
            mini.Image = imageList2.Images[1];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //base.BackColor = Color.Transparent;
        }

        
    }
}
