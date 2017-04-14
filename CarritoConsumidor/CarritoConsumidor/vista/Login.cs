using CarritoConsumidor.controladores;
using CarritoConsumidor.ServiceLogin;
using CarritoConsumidor.vista;
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

namespace CarritoConsumidor
{
    public partial class Login : Form
    {

        CtlLogin ctlLogin;

        usuario users;

        public Login()
        {
            InitializeComponent();
            ctlLogin = new CtlLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasenia.Text != "")
                {

                    users = ctlLogin.login(txtUsuario.Text, txtContrasenia.Text);

                    if (users != null)
                    {

                        Thread hiloInterfaz;
                        hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirGestionComprar));
                        this.Close();
                        hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
                        hiloInterfaz.Start();

                    }
                    else
                    {

                        MessageBox.Show("El usuario no se encuentra registrado por favor realice el registro");

                    }

                    

                }
                else
                {

                    MessageBox.Show("Por favor ingrese un dato en el campo contraseña");

                }

            }
            else
            {

                MessageBox.Show("Por favor ingrese un dato en el campo usuario");
            }
            


            

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz;
            hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirGestionRegistrar));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void abrirGestionRegistrar()
        {
            Registro regis = new Registro();
            regis.ShowDialog();
        }

        public void abrirGestionComprar()
        {
            Compra com = new Compra(users);
            com.ShowDialog();
        }
    }
}
