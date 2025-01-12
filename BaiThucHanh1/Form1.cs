﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string message = "";

            string userName = txtUser.Text;
            string password = txtPass.Text;
            bool isChecked = chkNho.Checked;

            message += $"Tên đăng nhập là:{userName}\nMật khẩu là:{password}";
            if (isChecked)
            {
                message += "\nBạn có nhớ";
            }
            
            MessageBox.Show(message);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();

            txtUser.Focus();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
