using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pierwszy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To pierwszy projekt w gicie, jak ktoś z was dopisze do tego linijkę to będzię pięknie:");
        }
    }
}
