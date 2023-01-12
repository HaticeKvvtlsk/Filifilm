using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class FilmRepositories : IRepository<Filmler>
    {
        FiliFilmEntities db = new FiliFilmEntities();

        public void delete(Filmler item)
        {
            Filmler silinecek = db.Filmler.Find(item);
            
            db.Filmler.Remove(silinecek);
            db.SaveChanges();
        }

        public List<Filmler> GetAll()
        {
            return db.Filmler.Where(x => x.IsDeleted == false).ToList();
            //var result = (from a in db.Filmler
            //              group a by a.FilmAdi into grp
            //              from a in grp
            //              join b in db.Cast on a.FilmID equals b.FilmID
            //              where a.IsDeleted == false
            //              orderby a.VizyonTarihi descending
            //              select new
            //              {

            //                  a.FilmID,
            //                  a.FilmAdi,
            //                  a.Aciklama,
            //                  a.YapimYili,
            //                  a.VizyonTarihi,
            //                  a.Picture,
            //                  a.Dil.Dil1,
            //                  a.Tur.Tur1,
            //                  a.Ulke.Ulke1,
            //                  b.CastKarakterName,
            //                  b.Oyuncular.OyuncuAdiSoyadi
            //              }).ToList();
            

        }

        public Filmler GetById(int id)
        {
            return db.Filmler.Find(id);
        }

        public void insert(Filmler item)
        {
            
           db.Filmler.Add(item);
            db.SaveChanges();
        }

        public void update(Filmler item)
        {
            Filmler guncellenecek = db.Filmler.Find(item.FilmID);
            //  db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.Entry(guncellenecek).CurrentValues.SetValues(item.FilmID);
            db.SaveChanges();
        }
    }
}
