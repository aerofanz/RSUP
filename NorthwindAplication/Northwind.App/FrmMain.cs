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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public bool IsLogout { get; internal set; }

        public FrmMain()
        {
            InitializeComponent();
        }

    }
}
