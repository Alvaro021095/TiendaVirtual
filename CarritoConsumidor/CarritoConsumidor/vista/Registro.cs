using CarritoConsumidor.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoConsumidor.vista
{
    public partial class Registro : Form
    {

        public CtlCliente ctlCli;

        public Registro()
        {
            InitializeComponent();
            ctlCli = new CtlCliente();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            String cedula = txtCedula.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String correo = txtCorreo.Text;
            String telefono = txtTelefono.Text;
            String usuario = txtUsuario.Text;
            String contrasenia = txtContrasenia.Text;

            if(cedula.Equals("") || nombre.Equals("") || apellido.Equals("") || correo.Equals("")
                || telefono.Equals("") || usuario.Equals("") || contrasenia.Equals("")){
                    MessageBox.Show("Porfavor complete los campos");
                }
            else
            {
                if(ctlCli.crear(apellido,cedula,correo,nombre,telefono,usuario,contrasenia)){
                    MessageBox.Show("Se creo con exito");
                    Thread hiloInterfaz;
                    hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirGestionLogin));
                    this.Close();
                    hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
                    hiloInterfaz.Start();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar");
                }
            }
            
        }


        public void abrirGestionLogin()
        {
            Login lo = new Login();
            lo.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            Thread hiloInterfaz;
            hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirGestionLogin));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();


        }
    }
}
