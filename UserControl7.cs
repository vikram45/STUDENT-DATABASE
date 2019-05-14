using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_DATABASE_MANAGEMENT_SYSTEM
{
    public partial class UserControl7 : UserControl
    {
        private static UserControl7 _instance;
        public static UserControl7 Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl7();
                }
                return _instance;

            }
        }
        public UserControl7()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {

        }
    }
}
