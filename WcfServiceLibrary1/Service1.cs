using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{

    public class Service1 : IService1
    {
        FiliFilmEntities db = new FiliFilmEntities();
        public List<Filmler> FilmleriGetir()
        {
            return db.Filmler.Where(film=>film.IsDeleted==false).Select(film =>film).ToList();
        }
    }
}
