using Model.Entites;
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
    public partial class FormActivity : Form
    {
        Exercise exercise;
        public FormActivity(Exercise _exercise)
        {
            InitializeComponent();
            exercise = _exercise;
        }
    }
}
