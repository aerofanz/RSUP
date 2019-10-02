﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Helper.UI.Template
{
    public partial class FrmEntryMaster : BaseFrmList
    {
        public FrmEntryMaster()
        {
            InitializeComponent();
        }

        public FrmEntryMaster(string header) : this()
        {
            Text = header;
            TabText = header;
            lblHeader.Text = header;
        }

        protected void LockButton(bool v, bool w)
        {
            btnAdd.Enabled = v;
            btnEdit.Enabled = v;
            btnDelete.Enabled = v;
            btnCancel.Enabled = w;
            btnSave.Enabled = w;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LockButton(false, true);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            LockButton(false, true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearArea();
            LockButton(true, false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
