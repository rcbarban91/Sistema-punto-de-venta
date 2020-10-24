using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_punto_de_venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        /***********************
         *                     *
         *  CODIGO DEL CLIENTE *
         *                     *
         ***********************/

        #region

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedIndex = 1;
        }
        #endregion
    }
}
