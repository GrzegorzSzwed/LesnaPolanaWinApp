using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LesnaPolanaWinApp.Classess;
using MongoDB.Driver;

namespace LesnaPolanaWinApp.Controls
{
    public partial class LogCntrl : UserControl
    {
        private User user;
        private DBMigrator DBMigrator;
        public LogCntrl(User user, DBMigrator migrator)
        {
            InitializeComponent();
            this.user = user;
            DBMigrator = migrator;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CleanCntrls();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var splitted = txtName.Text.Split('_');
                var name = splitted[0];
                var surname = splitted[1];
                var password = txtPassword.Text;

                try
                {
                    user = DBMigrator.LoadRecordByLoginAndPassword<User>(name, surname, password);
                    if (user == null)
                        MessageBox.Show("Operation failed");
                    else
                    {
                        DashboardForm.Instance.TblContainer.Controls.Remove(this);
                        var cntrl = new InvitationControl(user);
                        user.LastDate = DateTime.Now;
                        DBMigrator.UpdateRecord<User>("users",
                            user.id,
                            user);
                        DashboardForm.Instance.Employee = user;
                        cntrl.Dock = DockStyle.Fill;
                        DashboardForm.Instance.TblContainer.Controls.Add(cntrl);

                        DashboardForm.Instance.FlwMenu.Controls.Add(DashboardForm.Instance.BtnServices);
                        DashboardForm.Instance.FlwMenu.Controls.Add(DashboardForm.Instance.BtnMagazine);
                        DashboardForm.Instance.FlwMenu.Controls.Add(DashboardForm.Instance.BtnUsers);
                    }
                }
                catch (MongoException exception)
                {
                    MessageBox.Show(exception.Message.ToString());
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            if(txtName.Text!=string.Empty&&txtPassword.Text!=string.Empty)
            {
                var splitted = txtName.Text.Split('_');
                var name = splitted[0];
                var surname = splitted[1];
                var password = txtPassword.Text;

                user.Name = name;
                user.Surname = surname;
                user.Password = password;
                string msg;

                try
                {
                    var checkIfExists = DBMigrator.LoadRecordByLoginAndPassword<User>(name, surname, password);
                    if (checkIfExists == null)
                    {
                        try
                        {
                            user.LastDate = DateTime.UtcNow;
                            DBMigrator.InsertRecord<User>("users", user);
                            CleanCntrls();
                            msg = string.Format("Użytkownik {0} {1} dodany", user.Name, user.Surname);
                            MessageBox.Show(msg);
                        }
                        catch (MongoWriteException exception)
                        {
                            msg = string.Format("Użytkownik {0} {1} NIE został dodany, powodem jest: {2}", user.Name, user.Surname, exception.Message.ToString());
                            MessageBox.Show(msg);
                        }
                    }
                    else
                    {
                        msg = string.Format("Użytkownik {0} {1} istnieje już w bazie danych", user.Name, user.Surname);
                        MessageBox.Show(msg);
                    }
                    CleanCntrls();
                }
                catch(MongoException exception)
                {
                    MessageBox.Show(exception.Message.ToString());
                }
            }
        }

        private void CleanCntrls()
        {
            txtPassword.Text = string.Empty;
            txtName.Text = string.Empty;
        }
    }
}
