namespace Bank.Entities
{
    public class Usuario
    {

        private string usuario;
        private string clave;
        private float saldo;

        public Usuario(string usuario, string clave)
        {
            Username = usuario;
            Clave = clave;
            Saldo = 0;
        }

        public string Username{ get { return usuario; } set { usuario = value; } }
        public string Clave { get { return clave; } set { clave = value; } }
        public float Saldo { get { return saldo; } set { saldo = value; } }


    }
}
