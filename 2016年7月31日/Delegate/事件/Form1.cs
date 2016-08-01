using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(154, 62);
            btn.Size = new Size(75, 23);
            btn.Text = "动态的";
            btn.Click += new EventHandler(btn_Click);
            btn.Click += new EventHandler(btn_Click1);
            this.Controls.Add(btn);
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我被点击了！！！");
        }

        void btn_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("我又被点击了！！！");
        }
    }
}
