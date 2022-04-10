using Bank.Entities;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SecurityService securityService = new SecurityService();
            Usuario currentUser = securityService.login(txtUsuario.Text, txtClave.Text);

            if (currentUser != null)
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal(currentUser);
                menu.Show();
                //this.Hide();
                lblNotificacion.BackColor = Color.Green;
                lblNotificacion.Text = "Ingreso exitoso!";
                lblNotificacion.Visible = true;
                txtClave.Text = "";
                txtUsuario.Text = "";

            }
            else
            {
                lblNotificacion.BackColor = Color.Red;
                lblNotificacion.Text = "Los datos ingresados son incorrectos!";
                lblNotificacion.Visible = true;
            }
        }
    }
}
