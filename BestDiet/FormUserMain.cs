using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public partial class FormUserMain : Form
    {
        string _userName;
        public FormUserMain(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }
    }
}
