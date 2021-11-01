namespace Murray.Dao
{
    public interface IDao<T> where T : class
    {
        void Crear(T t);
        void LeerTodos();
        void Actualizar(T t);
        void Eliminar(T t);
    }
}
