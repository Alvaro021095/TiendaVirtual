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
        int valor1;

        public Compra(usuario users)
        {
            InitializeComponent();
            this.thisUser = users;
            ctlCom = new CtlCompras();
            valor1 = 0;
        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {

            //DataTable dt = (DataTable)ProductosBuscados.DataSource;

            if(ProductosBuscados != null){
                ProductosBuscados.Rows.Clear();
            }

            String nombrePro = txtNombrePro.Text;

            producto[] listaDeProdcutos = ctlCom.listarProducto(nombrePro);

            if (listaDeProdcutos != null)
            {
                for (int i = 0; i < listaDeProdcutos.Length; i++)
                {

                    ProductosBuscados.Rows.Add(listaDeProdcutos.ElementAt(i).nombre,
                        listaDeProdcutos.ElementAt(i).valor, listaDeProdcutos.ElementAt(i).cantidad);
                }
                

            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }

        private void Compra_Load(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Nombre";
            c1.Width = 50;


            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Valor";
            c2.Width = 50;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Cantidad";
            c3.Width = 50;

            ProductosBuscados.Columns.Add(c1);
            ProductosBuscados.Columns.Add(c2);
            ProductosBuscados.Columns.Add(c3);

        }

        private void btnAgregarCarri_Click(object sender, EventArgs e)
        {

          
            valor1 = (int)ProductosBuscados.CurrentRow.Cells["Cantidad"].Value;
            MessageBox.Show("" + valor1);

        }

        private void ProductosBuscados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
