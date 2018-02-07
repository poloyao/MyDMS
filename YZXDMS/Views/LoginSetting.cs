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

namespace YZXDMS.Views
{
    public partial class LoginSetting : Form
    {
        public LoginSetting()
        {
            InitializeComponent();
            this.MouseDown += Login_MouseDown;
            this.MouseMove += Login_MouseMove;
            this.MouseUp += Login_MouseUp;

            this.pictureBox1.MouseDown += Login_MouseDown;
            this.pictureBox1.MouseMove += Login_MouseMove;
            this.pictureBox1.MouseUp += Login_MouseUp;

        }

        bool beginMove = false;//初始化鼠标位置  
        int currentXPosition;
        int currentYPosition;


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pwd = Helper.DES.EncryptDES(this.textBox2.Text.Trim(), "syyzx2018");
            var query = Data.SQLiteProvider.SaveDBSetting(0, this.textBox1.Text.Trim(),this.textBox3.Text.Trim(), pwd);
            if (query != string.Empty)
                MessageBox.Show(query);
            else
                this.Close();
        }
    }
}
