using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Forms_LinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // TODO parse the JSON to Player class and fill the DataGrid component.
        }

        private void btn_orderScore_Click(object sender, EventArgs e)
        {
            // TODO order list by score
        }

        private void btn_orderName_Click(object sender, EventArgs e)
        {
            // TODO order list by name
        }
    }
}
