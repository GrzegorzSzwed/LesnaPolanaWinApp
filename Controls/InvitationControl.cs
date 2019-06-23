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

namespace LesnaPolanaWinApp.Controls
{
    public partial class InvitationControl : UserControl
    {
        public InvitationControl(User user)
        {
            InitializeComponent();
            lblSurname.Text = string.Format("{0} {1}!", user.Name, user.Surname);

            lblDay.Text = string.Format("{0} {1}:{2}", user.LastDate.DayOfWeek, user.LastDate.Hour, user.LastDate.Minute);
        }
    }
}
