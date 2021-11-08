using DataAccess1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;

namespace DataAccess1.Dao
{
    public class ItemDao:DaoBase<Item>
    {
        public ItemDao() : base()//dedení z předka
        {
        }
        public IList<Item> GetPagedItems(int count, int page, out int totalItems)//metoda pro nacitani rozumneho mnozstvi polozek z databaze
        {
            totalItems = session.CreateCriteria<Item>()
                 .SetProjection(Projections.RowCount())
                 .UniqueResult<int>();

            return session.CreateCriteria<Item>()//vypocet pro nastaveni indexu prvniho prvku na vybrané stránce 
                .AddOrder(Order.Asc("Name"))
                .SetFirstResult((page - 1) * count)
                .SetMaxResults(count)
                .List<Item>();
        }
        public IList<Item> SearchItems(string searchStr)//metoda pro nacitani rozumneho mnozstvi polozek z databaze
        {
            return session.CreateCriteria<Item>()
                .Add(Restrictions
                .Like("Name", string.Format("%{0}%", searchStr)))
                .List<Item>();

        }

        public IList<Item> FilterItemsByCategory(int id)//metoda pro nacitani dle categorie
        {
            return session.CreateCriteria<Item>()
                .CreateAlias("Category", "cat")
                .Add(Restrictions.Eq("cat.Id", id))
                .List<Item>();

        }



    }
}
