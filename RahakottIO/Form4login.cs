using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace RahakottIO
{
    public partial class Form4login : Form
    {
        public Form4login()
        {
            InitializeComponent();
        }
        string KryptoedStr;
        string str4apikey;
        void back2reg()
        {
            Text = "RahakottIO - 账户创建与登录";
            lb4title.Text = "账户创建与登录";
            lb4pwd0title.Text = "创建支付密码";
            btn4login.Text = "创建并登录账户";
            txt4apikey.Text = "";
            txt4apikey.ReadOnly = false;
            txt4apikey.TabIndex = 0;
        }
        void Krypto(string str4Krypto)
        {
            byte[] result = Encoding.Default.GetBytes(str4Krypto.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            str4Krypto = BitConverter.ToString(output).Replace("-", "");
            KryptoedStr = str4Krypto.ToLower();//输出小写字母
        }

        private void lb4apipage_Click(object sender, EventArgs e)
        {
            Process.Start("https://rahakott.io/settings/api");
        }
        bool ifhasReg()
        {
            FileStream fsrd = File.OpenRead(@"config\apikey.cain");
            StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            str4apikey = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            if (str4apikey == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void login()
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            Hide();
        }
        void canulogin()
        {
            if (ifhasReg() == false)
            {

            }
            else
            {
                Text = "RahakottIO - 账户登录";
                lb4title.Text = "账户登录";
                lb4pwd0title.Text = "输入支付密码";
                btn4login.Text = "登录账户";
                txt4apikey.Text = str4apikey.Substring(0, str4apikey.Length - 8) + "********";
                txt4apikey.ReadOnly = true;
                txt4pwd.TabIndex = 0;
                btn4forgetpwd.Visible = true;
            }
        }
        private void btn4login_Click(object sender, EventArgs e)
        {
            if (ifhasReg() == false)
            {
                FileStream fscr = File.Create(@"config\apikey.cain");
                StreamWriter sw = new StreamWriter(fscr, System.Text.Encoding.Default);
                sw.Write(txt4apikey.Text);
                sw.Close();
                fscr.Close();
                Krypto(txt4pwd.Text);
                fscr = File.Create(@"config\paypwd.cain");
                sw = new StreamWriter(fscr, System.Text.Encoding.Default);
                sw.Write(KryptoedStr);
                sw.Close();
                fscr.Close();
                login();
            }
            else
            {
                if (txt4pwd.Text != "")
                {
                    FileStream fsrd = File.OpenRead(@"config\paypwd.cain");
                    StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
                    string str4paypwd = sr.ReadToEnd();
                    sr.Close();
                    fsrd.Close();
                    Krypto(txt4pwd.Text);
                    if (KryptoedStr == str4paypwd)
                    {
                        login();
                    }
                    else
                    {
                        MessageBox.Show("支付密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("请输入支付密码来登录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form4login_Load(object sender, EventArgs e)
        {
            canulogin();
        }
        private void btn4forgetpwd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("如果您忘记了密码可以删除旧账户并重新创建。\r\n确定要删除么？", "忘记密码", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //确定按钮的方法
                MessageBox.Show("成功！您的旧账户已删除。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                back2reg();
                FileStream fscr = File.Create(@"config\apikey.cain");
                StreamWriter sw = new StreamWriter(fscr, System.Text.Encoding.Default);
                sw.Write("");
                sw.Close();
                fscr.Close();
                Krypto(txt4pwd.Text);
                fscr = File.Create(@"config\paypwd.cain");
                sw = new StreamWriter(fscr, System.Text.Encoding.Default);
                sw.Write("");
                sw.Close();
                fscr.Close();
            }
            else
            {
                //取消按钮的方法
            }
        }
        private void txt4pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn4login.PerformClick();
                e.Handled = true;
            }
        }
    }
}
