using ProjekatBaze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaWPF.Baza
{
    public class ProcitajIzBaze
    {

        public List<Teratana> ProcitajTeretanu()
        {
            List<Teratana> exit = new List<Teratana>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Teratanas)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }


        public List<Uzima> ProcitajUzima()
        {
            List<Uzima> exit = new List<Uzima>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Uzimas)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

        public List<Ide> ProcitajIde()
        {
            List<Ide> exit = new List<Ide>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Ides)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }


        public List<ProbniTrening> ProcitajProbniTrening()
        {
            List<ProbniTrening> exit = new List<ProbniTrening>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.ProbniTrenings)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }


        public List<Radi> ProcitajRadi()
        {
            List<Radi> exit = new List<Radi>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Radis)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }


        public List<Zaposleni> ProcitajZaposlenog()
        {
            List<Zaposleni> exit = new List<Zaposleni>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Zaposlenis)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

        public List<CasTreninga> ProcitajCasTreninga()
        {
            List<CasTreninga> exit = new List<CasTreninga>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.CasTreningas)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

        public List<Clan> ProcitajClanove()
        {
            List<Clan> exit = new List<Clan>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.Clans)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

        public List<ObicanVezbac> ProcitajVezbace()
        {
            List<ObicanVezbac> exit = new List<ObicanVezbac>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.ObicanVezbacs)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

        public List<OpremaUteretani> ProcitajOpremu()
        {
            List<OpremaUteretani> exit = new List<OpremaUteretani>();

            using (var db = new Model1Context())
            {
                try
                {
                    foreach (var item in db.OpremaUteretanis)
                    {
                        exit.Add(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            return exit;
        }

    }
}
