using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1
{
    public class NHibernateHelper
    {
        //Session factory narocny na CPU proto objekt zaklad pro session factory-Singlton
        //konfigurace NHibernatu
        private static ISessionFactory _factory;

        public static ISession Session
        {
            get
            {
                if (_factory == null)
                {
                    var cfg = new Configuration();

                    //factory vyhledat cestu ke konfiguracnimu souboru a zbuildit zakladni pripojeni k databazi
                    _factory = cfg.Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hibernate.cfg.xml")).BuildSessionFactory();
                }
                return _factory.OpenSession();
            }

        }



    }
}
