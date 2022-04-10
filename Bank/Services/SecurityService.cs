using Bank.DataStorage;
using Bank.Entities;

namespace Bank.Services
{
    public class SecurityService
    {
        public Usuario login(String txtUsuario, String txtClave)
        {
            Usuario result = null;
            SecurityData data = new SecurityData();
            Usuario[] users = data.getUsuarios();
            foreach (Usuario user in users)
            {
                if (user.Username == txtUsuario && user.Clave == txtClave)
                {
                    result = user;
                    break;
                }
            }

            return result;
        }
    }
}
