using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Dao
{
    public class ItemDao:DaoBase<Item>
    {
        public ItemDao() : base()//dedení z předka
        {
        }
    }
}
