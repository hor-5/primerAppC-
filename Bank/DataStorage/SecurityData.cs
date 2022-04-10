using Bank.Entities;

namespace Bank.DataStorage
{
    public class SecurityData
    {
        private Usuario[] dataUsers = new Usuario[4];

        public Usuario[] getUsuarios() {

            dataUsers[0] = new Usuario("pedro", "1234");
            dataUsers[1] = new Usuario("juan", "prueba");
            dataUsers[2] = new Usuario("lorena", "1563");
            dataUsers[3] = new Usuario("jose", "probando");

            return dataUsers;
        }
    }
}
