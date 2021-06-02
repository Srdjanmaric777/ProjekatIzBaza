using ProjekatBaze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaWPF.Baza
{
    public class IzbrisiIzBaze
    {
        public int IzbrisiTeretanu(int id)
        {
            using (var db = new Model1Context())
            {
                Teratana teratana = db.Teratanas.Where(c => c.Lokacija.Equals(id)).FirstOrDefault();

                try
                {
                    db.Entry(teratana).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }


        public int IzbrisiCasTreninga(int id)
        {
            using (var db = new Model1Context())
            {

                CasTreninga casTreninga = db.CasTreningas.Where(c => c.IdCasTreninga.Equals(id)).FirstOrDefault();


                try
                {
                    db.Entry(casTreninga).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int IzbrisiUzima(int id)
        {
            using (var db = new Model1Context())
            {

                Uzima uzima = db.Uzimas.Where(c => c.CasTreningaIdCasTreninga.Equals(id)).FirstOrDefault();


                try
                {
                    db.Entry(uzima).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int IzbrisiClana(int id)
        {
            using (var db = new Model1Context())
            {

                Clan clan = db.Clans.Where(c => c.Kartica.Equals(id)).FirstOrDefault();


                try
                {
                    db.Entry(clan).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int IzbrisiVezbaca(int id)
        {
            using (var db = new Model1Context())
            {

                ObicanVezbac vezbac = db.ObicanVezbacs.Where(c => c.IdObicanVezbac.Equals(id)).FirstOrDefault();


                try
                {
                    db.Entry(vezbac).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int IzbrisiZaposlenog(int id)
        {
            using (var db = new Model1Context())
            {

                Zaposleni zaposleni = db.Zaposlenis.Where(c => c.IdBedz.Equals(id)).FirstOrDefault();


                try
                {
                    db.Entry(zaposleni).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
        }
    }
}
