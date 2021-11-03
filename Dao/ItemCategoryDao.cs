using DataAccess1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Dao
{
    public class ItemCategoryDao : DaoBase<ItemCategory>
    {
        public ItemCategoryDao() : base()//pojisteni pro dedení z předka DaoBase<ItemCategory>
        {
        }
    }
}
