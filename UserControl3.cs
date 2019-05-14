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
    public partial class UserControl3 : UserControl
    {
        private static UserControl3 _instance;
        public static UserControl3 Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl3();
                }
                return _instance;

            }
        }
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
