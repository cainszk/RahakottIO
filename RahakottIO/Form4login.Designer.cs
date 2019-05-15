namespace RahakottIO
{
    partial class Form4login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt4apikey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic4logo = new System.Windows.Forms.PictureBox();
            this.lb4title = new System.Windows.Forms.Label();
            this.lb4pwd0title = new System.Windows.Forms.Label();
            this.txt4pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb4apipage = new System.Windows.Forms.Label();
            this.btn4login = new System.Windows.Forms.Button();
            this.btn4forgetpwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic4logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "API密钥";
            // 
            // txt4apikey
            // 
            this.txt4apikey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4apikey.Location = new System.Drawing.Point(120, 149);
            this.txt4apikey.Name = "txt4apikey";
            this.txt4apikey.Size = new System.Drawing.Size(353, 29);
            this.txt4apikey.TabIndex = 4;
            this.txt4apikey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(194, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 40;
            this.label3.Text = "数字货币钱包 客户端";
            // 
            // pic4logo
            // 
            this.pic4logo.Image = ((System.Drawing.Image)(resources.GetObject("pic4logo.Image")));
            this.pic4logo.Location = new System.Drawing.Point(12, 12);
            this.pic4logo.Name = "pic4logo";
            this.pic4logo.Size = new System.Drawing.Size(176, 61);
            this.pic4logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4logo.TabIndex = 39;
            this.pic4logo.TabStop = false;
            // 
            // lb4title
            // 
            this.lb4title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb4title.ForeColor = System.Drawing.Color.Teal;
            this.lb4title.Location = new System.Drawing.Point(12, 93);
            this.lb4title.Name = "lb4title";
            this.lb4title.Size = new System.Drawing.Size(461, 31);
            this.lb4title.TabIndex = 41;
            this.lb4title.Text = "账户创建与登录";
            this.lb4title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb4pwd0title
            // 
            this.lb4pwd0title.AutoSize = true;
            this.lb4pwd0title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lb4pwd0title.Location = new System.Drawing.Point(8, 187);
            this.lb4pwd0title.Name = "lb4pwd0title";
            this.lb4pwd0title.Size = new System.Drawing.Size(106, 21);
            this.lb4pwd0title.TabIndex = 43;
            this.lb4pwd0title.Text = "创建支付密码";
            // 
            // txt4pwd
            // 
            this.txt4pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4pwd.Location = new System.Drawing.Point(120, 184);
            this.txt4pwd.Name = "txt4pwd";
            this.txt4pwd.PasswordChar = '*';
            this.txt4pwd.Size = new System.Drawing.Size(353, 29);
            this.txt4pwd.TabIndex = 42;
            this.txt4pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4pwd_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "我没有API密钥？请进入以下网址登录并获取。";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb4apipage
            // 
            this.lb4apipage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lb4apipage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lb4apipage.Location = new System.Drawing.Point(12, 319);
            this.lb4apipage.Name = "lb4apipage";
            this.lb4apipage.Size = new System.Drawing.Size(461, 21);
            this.lb4apipage.TabIndex = 45;
            this.lb4apipage.Text = "https://rahakott.io/settings/api";
            this.lb4apipage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb4apipage.Click += new System.EventHandler(this.lb4apipage_Click);
            // 
            // btn4login
            // 
            this.btn4login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4login.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4login.ForeColor = System.Drawing.Color.Teal;
            this.btn4login.Location = new System.Drawing.Point(12, 235);
            this.btn4login.Name = "btn4login";
            this.btn4login.Size = new System.Drawing.Size(461, 54);
            this.btn4login.TabIndex = 46;
            this.btn4login.Text = "创建并登录账户";
            this.btn4login.UseVisualStyleBackColor = true;
            this.btn4login.Click += new System.EventHandler(this.btn4login_Click);
            // 
            // btn4forgetpwd
            // 
            this.btn4forgetpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4forgetpwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4forgetpwd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn4forgetpwd.Location = new System.Drawing.Point(385, 93);
            this.btn4forgetpwd.Name = "btn4forgetpwd";
            this.btn4forgetpwd.Size = new System.Drawing.Size(88, 31);
            this.btn4forgetpwd.TabIndex = 47;
            this.btn4forgetpwd.Text = "忘记密码";
            this.btn4forgetpwd.UseVisualStyleBackColor = true;
            this.btn4forgetpwd.Visible = false;
            this.btn4forgetpwd.Click += new System.EventHandler(this.btn4forgetpwd_Click);
            // 
            // Form4login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 349);
            this.Controls.Add(this.btn4forgetpwd);
            this.Controls.Add(this.btn4login);
            this.Controls.Add(this.lb4apipage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb4pwd0title);
            this.Controls.Add(this.txt4pwd);
            this.Controls.Add(this.lb4title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic4logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4apikey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RahakottIO - 账户创建与登录";
            this.Load += new System.EventHandler(this.Form4login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic4logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt4apikey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic4logo;
        private System.Windows.Forms.Label lb4title;
        private System.Windows.Forms.Label lb4pwd0title;
        private System.Windows.Forms.TextBox txt4pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb4apipage;
        private System.Windows.Forms.Button btn4login;
        private System.Windows.Forms.Button btn4forgetpwd;
    }
}