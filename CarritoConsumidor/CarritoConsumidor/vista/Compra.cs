using CarritoConsumidor.controladores;
using CarritoConsumidor.ServiceLogin;
using CarritoConsumidor.ServiceProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoConsumidor.vista
{
    public partial class Compra : Form
    {
        usuario thisUser;
        public CtlCompras ctlCom;

        public Compra(usuario users)
        {
            InitializeComponent();
            this.thisUser = users;
            ctlCom = new CtlCompras();
        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {

            String nombrePro = txtNombrePro.Text;

            producto[] listaDeProdcutos = ctlCom.listarProducto(nombrePro);

            if(listaDeProdcutos != null){



            }
            else
            {
                MessageBox.Show("No existe el producto");
            }


        }

        private void Compra_Load(object sender, EventArgs e)
        {

            DataGridTextBoxColumn c1 = new DataGridTextBoxColumn();
            c1.HeaderText="Nombre";
            c1.Width = 50;


            DataGridTextBoxColumn c2 = new DataGridTextBoxColumn();
            c2.HeaderText = "Valor";
            c2.Width = 50;

            DataGridTextBoxColumn c3 = new DataGridTextBoxColumn();
            c3.HeaderText = "Cantidad";
            c3.Width = 50;

        }
    }
}
