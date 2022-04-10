namespace Bank.Entities
{
    public class Usuario
    {

        private string Username { get; set; }
        private string Clave { get; set; }
        private float Saldo { get; set; }

        public Usuario(string usuario, string clave)
        {
            Username = usuario;
            Clave = clave;
            Saldo = 0;
        }


    }
}
