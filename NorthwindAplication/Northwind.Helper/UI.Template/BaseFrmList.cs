using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace Northwind.Helper.UI.Template
{
    public class BaseFrmList : DockContent
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // BaseFrmList
            //
            this.ClientSize = new System.Drawing.Size(481, 316);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
                                                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BaseFrmList";
            this.TabText = " ";
            this.Text = " ";
            this.ResumeLayout(false);
        }

        protected virtual void SaveData() { } // Fungsi Save Data
        protected virtual void LoadData() { } // Fungsi Save Data
        protected virtual void UpdateData() { } // Fungsi Update Data
        protected virtual void DeleteData() { } // Fungsi Delete Data
        protected virtual void ClearArea() { } // Fungsi Clear Data

    }
}
