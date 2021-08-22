using System.Data.Linq;
using EasyIngresso.DAO.Entity;

namespace EasyIngresso.DAO.Implementation
{
    public class SuperDAO<T> : ISuperDAO<T> where T : class
    {
        public Table<T> GetTable()
        {
            using (var context = new ModelDataContext())
            {
                return context.GetTable<T>();
            }
        }
    }
}
