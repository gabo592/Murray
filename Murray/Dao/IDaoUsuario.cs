using Murray.Poco;

namespace Murray.Dao
{
    public interface IDaoUsuario : IDao<Usuario>
    {
        Usuario ValidarUsuario(string nickName, string password);
    }
}
