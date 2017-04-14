using CarritoConsumidor.ServiceLogin;
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
        public Compra(usuario users)
        {
            InitializeComponent();
            this.thisUser = users;
        }
    }
}
