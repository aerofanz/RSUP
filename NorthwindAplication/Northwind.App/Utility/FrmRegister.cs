using Northwind.BLL_api;
using Northwind.BLL_service;
using Northwind.Helper;
using Northwind.Helper.UI.Template;
using Northwind.Model;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.App.Utility
{
    public partial class FrmRegister : FrmEntryMaster
    {
        private IAuthBLL _authBLL;
        private IRoleBLL _roleBLL;

        private IList<User> _lstUser = new List<User>();
        private IList<Role> _lstRole = new List<Role>();

        public FrmRegister(string header) : base(header)
        {
            InitializeComponent();
            _authBLL = new AuthBLL();
            _roleBLL = new RoleBLL();
            LoadData();
            InitGrid();
            LoadRole();
        }

        private void LoadRole()
        {
            cboGroup.DataSource = _lstRole;
            cboGroup.DisplayMember = "Name";
            cboGroup.ValueMember = "Id";

            cboGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void LoadData()
        {
            _lstUser = _authBLL.GetAll();
            _lstRole = _roleBLL.GetAll();
        }

        private void InitGrid()
        {
            var glProp = new List<GridListControlProperties>();

            glProp.Add(new GridListControlProperties { Header = "No", Width = 30 });
            glProp.Add(new GridListControlProperties { Header = "User Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "First Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "Last Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "Roles", Width = 200 });

            GridListControlHelper.InitializeGridListControl<User>(grLstUser, _lstUser, glProp);

            if (_lstUser.Count > 0)
                this.grLstUser.SetSelected(0, true);

            grLstUser.Grid.QueryCellInfo += delegate (object sender, GridQueryCellInfoEventArgs e)
            {
                if(_lstUser.Count > 0)
                {
                    if(e.RowIndex > 0)
                    {
                        var rowIndex = e.RowIndex - 1;
                        if(rowIndex < _lstUser.Count)
                        {
                            var users = _lstUser[rowIndex];
                            switch (e.ColIndex)
                            {
                                case 2:
                                    e.Style.CellValue = users.userId;
                                    break;
                                case 3:
                                    e.Style.CellValue = users.firstName;
                                    break;
                                case 4:
                                    e.Style.CellValue = users.lastName;
                                    break;
                                case 5:
                                    e.Style.CellValue = users.roles;
                                    break;
                                default:
                                    break;
                            }
                            e.Handled = true;
                        }
                    }
                }
            };

        }

      


    }
}
