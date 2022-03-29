namespace Bank.Entities
{
    public class Usuario
    {
        //private int id;
        //private string name;
        //private DateTime fechaNac;
        private string usuario;
        private string clave;
        private float saldo;

        public Usuario(string usuario, string clave, float saldo)
        {
            Username = usuario;
            Clave = clave;
            Saldo = saldo;
        }

        public string Username
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public void login(TextBox txtUsuario, TextBox txtClave, Label lblNotificacion)
        {

            if (Username == txtUsuario.Text && Clave == txtClave.Text)
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal(this);
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
