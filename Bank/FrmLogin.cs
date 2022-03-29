using Bank.Entities;

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
            Usuario pedro = new Usuario("pedro", "1234", 75841);
            Usuario juan = new Usuario("juan", "prueba", 800);
            juan.login(txtUsuario, txtClave, lblNotificacion);
            pedro.login(txtUsuario, txtClave, lblNotificacion);
            //La notificacion de ingreso solamente funciona con la ultima linea...
            //se resolveria con el uso de un array de Usuarios.

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
