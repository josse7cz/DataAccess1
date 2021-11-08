using DataAccess1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;


namespace DataAccess1.Dao
{
    public class ReceiptDao : DaoBase<Receipt>
    {
        public ReceiptDao() : base()
        {
        }

        public IList<Receipt> GetReceiptById(int id)//metoda pro nacitani dle uctenky
        {
            return session.CreateCriteria<Receipt>()
                .CreateAlias("Receipts", "rec")
                .Add(Restrictions.Eq("rec.Id", id))
                .List<Receipt>();




        }
    }
}
