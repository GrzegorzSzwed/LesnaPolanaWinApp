using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LesnaPolanaWinApp.Classess;
using LesnaPolanaWinApp.Controls;

namespace LesnaPolanaWinApp
{
    public partial class DashboardForm : Form
    {
        static DashboardForm _obj;
        private Point lastClick;
        private Point tmpLocation;
        private DBMigrator DBMigrator;
        private User employee = new User();
        public DashboardForm()
        {
            InitializeComponent();
            DBMigrator = new DBMigrator("LesnaPolanaApp");
            _obj = this;

            flwMenu.Controls.Clear();
            tblDashboard.Controls.Add(new LogCntrl(employee,DBMigrator));
            tblDashboard.Controls[2].Anchor = AnchorStyles.None;
        }
        public Button BtnUsers
        {
            get { return btnUsers; }
            set { btnUsers = value; }
        }

        public Button BtnServices
        {
            get { return btnServices; }
            set { btnServices = value; }
        }

        public Button BtnMagazine
        {
            get { return btnMagazine; }
            set { btnMagazine = value; }
        }

        public FlowLayoutPanel FlwMenu
        {
            get { return flwMenu; }
            set { flwMenu = value; }
        }

        public User Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public static DashboardForm Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new DashboardForm();

                return _obj;
            }
        }

        public TableLayoutPanel TblContainer
        {
            get { return tblDashboard; }
            set { tblDashboard = value; }
        }

        #region Events
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                tmpLocation.X = this.Left + (e.X - lastClick.X);
                tmpLocation.Y = this.Top + (e.Y - lastClick.Y);
                this.Location = tmpLocation;
            }
        }

        private void PnlTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        private void FlwMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMagazine_Click(object sender, EventArgs e)
        {
            tblDashboard.Controls.Remove(tblDashboard.Controls[2]);
            StoreControl storeControl = new StoreControl(employee, DBMigrator);
            storeControl.Dock = DockStyle.Fill;
            tblDashboard.Controls.Add(storeControl);
        }
    }
}
