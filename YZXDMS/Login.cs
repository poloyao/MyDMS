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
using UseIdentity;

namespace YZXDMS
{
    public partial class Login : Form
    {
        public bool IsOK;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += Login_MouseDown;
            this.MouseMove += Login_MouseMove;
            this.MouseUp += Login_MouseUp;

            this.pictureBox1.MouseDown += Login_MouseDown;
            this.pictureBox1.MouseMove += Login_MouseMove;
            this.pictureBox1.MouseUp += Login_MouseUp;

            this.label3.MouseDown += Login_MouseDown;
            this.label3.MouseMove += Login_MouseMove;
            this.label3.MouseUp += Login_MouseUp;

            var query = Data.SQLiteProvider.GetDBSetting();


        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态  
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x  
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标  
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标  
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标  
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.White;
            //this.BackColor = Color.Transparent;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        bool beginMove = false;//初始化鼠标位置  
        int currentXPosition;
        int currentYPosition;


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //x
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //V
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var view = new Views.LoginSetting();
            view.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.label4.Visible)
            {
                IsOK = true;
                this.Close();
                //var view = new Form1();
                //this.Hide();
                //view.Show();
            }
            else
            {
                var result = Common.UserLogin(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), Common.GetLocalIP(), "主控");
                this.label4.Visible = true;
                this.label4.Text = result;
            }
        }
    }
}
