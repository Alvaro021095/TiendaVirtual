using CarritoConsumidor.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoConsumidor
{
    public partial class Login : Form
    {

        CtlCliente ctlCli;

        public Login()
        {
            InitializeComponent();
            ctlCli = new CtlCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctlCli.crear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
