using ProjekatBaze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaWPF.Baza
{
    public class DodajUBazu
    {
        public int DOdajTeretanu(int id, string naziv, int brojTelefona/*, int menadzerID*/)
        {
            Teratana teretana;
            //Zaposleni menadzer;

            using (var db = new Model1Context())
            {
                try
                {

                    teretana = db.Teratanas.Where(t => t.Lokacija.Equals(id)).FirstOrDefault();
                    //menadzer = db.Zaposlenis.Where(z => z.IdBedz.Equals(menadzerID)).FirstOrDefault();

                    if (teretana != null)
                        return 2;

                    else
                    {
                        teretana = new Teratana
                        {
                            Lokacija = id,
                            Naziv = naziv,
                            BrojTelefona = brojTelefona
                            //MenadzerIdBedz = menadzer.IdBedz
                        };

                        db.Teratanas.Add(teretana);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int DodajZaposlenog(int idbedz, string ime, string prezime, string tip/*, string sertifikat, int oprema*/)
        {

            ProjekatBaze.Zaposleni zaposleni;

            using (var db = new Model1Context())
            {
                try
                {
                    zaposleni = db.Zaposlenis.Where(t => t.IdBedz.Equals(idbedz)).FirstOrDefault();


                    if (zaposleni != null)
                        return 2;
                    else
                    {
                        switch (tip)
                        {
                            case "Menadzer":
                                zaposleni = new Menadzer();
                                zaposleni.IdBedz = idbedz;
                                zaposleni.Ime = ime;
                                zaposleni.Prezime = prezime;
                                zaposleni.Tip = tip;
                                db.Zaposlenis.Add(zaposleni);
                                db.SaveChanges();
                                break;
                            case "Recepcionista":
                                zaposleni = new Recepcionista();
                                zaposleni.IdBedz = idbedz;
                                zaposleni.Ime = ime;
                                zaposleni.Prezime = prezime;
                                zaposleni.Tip = tip;
                                db.Zaposlenis.Add(zaposleni);
                                db.SaveChanges();
                                break;
                            case "Cistacica":
                                zaposleni = new Cistacica();
                                zaposleni.IdBedz = idbedz;
                                zaposleni.Ime = ime;
                                zaposleni.Prezime = prezime;
                                zaposleni.Tip = tip;
                                db.Zaposlenis.Add(zaposleni);
                                db.SaveChanges();
                                break;
                            case "Trener":
                                zaposleni = new Trener();
                                zaposleni.IdBedz = idbedz;
                                zaposleni.Ime = ime;
                                zaposleni.Prezime = prezime;
                                zaposleni.Tip = tip;
                                //trener.Sertifikat = sertifikat;
                                //trener.OpremaUteretaniIdOprema = oprema;
                                db.Zaposlenis.Add(zaposleni);
                                db.SaveChanges();
                                break;
                        }

                        //zaposleni = new Zaposleni
                        //{
                        //    IdBedz = idbedz,
                        //    Ime = ime,
                        //    Prezime = prezime
                        //};



                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int DodajCasTreninga(int id, string datum, int brojClanova)
        {
            CasTreninga casTreninga;

            using (var db = new Model1Context())
            {
                try
                {

                    casTreninga = db.CasTreningas.Where(t => t.IdCasTreninga.Equals(id)).FirstOrDefault();


                    if (casTreninga != null)
                        return 2;

                    else
                    {
                        casTreninga = new CasTreninga
                        {
                            IdCasTreninga = id,
                            DatumIVreme = DateTime.Parse(datum),
                            BrojClanova = brojClanova
                        };

                        db.CasTreningas.Add(casTreninga);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int DodajClana(int id, string ime, string prezime, int oprema)
        {
            Clan clan;

            using (var db = new Model1Context())
            {
                try
                {

                    clan = db.Clans.Where(t => t.Kartica.Equals(id)).FirstOrDefault();


                    if (clan != null)
                        return 2;

                    else
                    {
                        clan = new Clan
                        {
                            Kartica = id,
                            Ime = ime,
                            Prezime = prezime,
                            OpremaZaVezbanje = oprema
                        };

                        db.Clans.Add(clan);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }

        public int DodajObicnogVezbaca(int id, string ime, string prezime, int oprema)
        {
            ObicanVezbac obicanVezbac;

            using (var db = new Model1Context())
            {
                try
                {

                    obicanVezbac = db.ObicanVezbacs.Where(t => t.IdObicanVezbac.Equals(id)).FirstOrDefault();


                    if (obicanVezbac != null)
                        return 2;

                    else
                    {
                        obicanVezbac = new ObicanVezbac
                        {
                            IdObicanVezbac = id,
                            Ime = ime,
                            Prezime = prezime,
                            OpremaZaVezbanje = oprema
                        };

                        db.ObicanVezbacs.Add(obicanVezbac);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }


        public int DodajUzima(int idCas, int idClan)
        {
            Uzima uzima;

            using (var db = new Model1Context())
            {
                try
                {

                    uzima = db.Uzimas.Where(t => t.CasTreningaIdCasTreninga.Equals(idCas)).FirstOrDefault();
                    uzima = db.Uzimas.Where(t => t.ClanKartica.Equals(idClan)).FirstOrDefault();


                    if (uzima != null)
                        return 2;

                    else
                    {
                        uzima = new Uzima
                        {
                            CasTreningaIdCasTreninga = idCas,
                            ClanKartica = idClan
                        };

                        db.Uzimas.Add(uzima);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }


        public int DodajIde(int idTeretana, int idClan)
        {
            Ide ide;

            using (var db = new Model1Context())
            {
                try
                {

                    ide = db.Ides.Where(t => t.TeratanaLokacija.Equals(idTeretana)).FirstOrDefault();
                    ide = db.Ides.Where(t => t.ClanKartica.Equals(idClan)).FirstOrDefault();


                    if (ide != null)
                        return 2;

                    else
                    {
                        ide = new Ide
                        {
                            TeratanaLokacija = idTeretana,
                            ClanKartica = idClan
                        };

                        db.Ides.Add(ide);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }


        public int DodajProbniTrening(int idTeretana, int idVezbac)
        {
            ProbniTrening probniTrening;

            using (var db = new Model1Context())
            {
                try
                {

                    probniTrening = db.ProbniTrenings.Where(t => t.TeratanaLokacija.Equals(idTeretana)).FirstOrDefault();
                    probniTrening = db.ProbniTrenings.Where(t => t.ObicanVezbacIdObicanVezbac.Equals(idVezbac)).FirstOrDefault();


                    if (probniTrening != null)
                        return 2;

                    else
                    {
                        probniTrening = new ProbniTrening
                        {
                            TeratanaLokacija = idTeretana,
                            ObicanVezbacIdObicanVezbac = idVezbac
                        };

                        db.ProbniTrenings.Add(probniTrening);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }


        public int DodajRadi(int idTeretana, int idZaposleni)
        {
            Radi radi;

            using (var db = new Model1Context())
            {
                try
                {

                    radi = db.Radis.Where(t => t.TeratanaLokacija.Equals(idTeretana)).FirstOrDefault();
                    radi = db.Radis.Where(t => t.ZaposleniIdBedz.Equals(idZaposleni)).FirstOrDefault();


                    if (radi != null)
                        return 2;

                    else
                    {
                        radi = new Radi
                        {
                            TeratanaLokacija = idTeretana,
                            ZaposleniIdBedz = idZaposleni
                        };

                        db.Radis.Add(radi);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }




        public int DodajOpremu(int id, string naziv, int kolicina)
        {
            OpremaUteretani opremaUteretani;

            using (var db = new Model1Context())
            {
                try
                {

                    opremaUteretani = db.OpremaUteretanis.Where(t => t.IdOprema.Equals(id)).FirstOrDefault();


                    if (opremaUteretani != null)
                        return 2;

                    else
                    {
                        opremaUteretani = new OpremaUteretani
                        {
                            IdOprema = id,
                            Naziv = naziv,
                            Kolicina = kolicina
                        };

                        db.OpremaUteretanis.Add(opremaUteretani);
                        db.SaveChanges();

                        return 0;
                    }
                }
                catch
                {
                    return 1;
                }
            }
        }


    }
}
