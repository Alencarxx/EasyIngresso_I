using System.Data.Linq;

namespace EasyIngresso.DAO
{
    public interface ISuperDAO<T> where T : class
    {
        Table<T> GetTable();
    }
}
