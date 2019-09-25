﻿using Northwind.BLL_api;
using Northwind.BLL_service;
using Northwind.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isLogin;
            User user = new User();
            IAuthBLL authBLL = new AuthBLL();
            isLogin = authBLL.Login(txtUserID.Text, txtPassword.Text, ref user);

            if (isLogin)
            {
                Program.user = user;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Berhasil Login, Horeee");
            }
            else
                MessageBox.Show("User Name atau Password Salah");

            // fandy
            // Tintin77
            
        }
    }
}
