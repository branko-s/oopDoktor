using System;
using System.Collections.Generic;

namespace oopDoktor_ns
{
    class Program
    {
        static void interfejs()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("oopDoktor");
            Console.WriteLine("Opcije:");
            Console.WriteLine("\t1. Dodaj doktora.");
            Console.WriteLine("\t2. Dodaj pacijenta.");
            Console.WriteLine("\t3. Pacijent bira doktora.");
            Console.WriteLine("\t4. Zakazi pregled.");
            Console.WriteLine("\t5. Unesi rezultate pregleda.");
            Console.WriteLine("\t6. Izlaz.");
            Console.WriteLine("*************************************************");
        }

        static void unos_doktora()
        {
            string ime, prezime, specijalnost;
            long jmbg;

            ime = unos.unos_ime_prezime("Unesite ime doktora.");

            prezime = unos.unos_ime_prezime("Unesite prezime doktora.");

            jmbg = unos.unos_jmbg("Unesite jmbg doktora.");

            specijalnost = unos.unos_ime_prezime("Unesite specijalnost doktora.");

            doktor d = new doktor(ime, prezime, jmbg, specijalnost);

            doktor.Lista_doktora.Add(d);
        }

        static void unos_pacijenta()
        {
            string ime, prezime;
            long jmbg, br_zdr_kartona;

            ime = unos.unos_ime_prezime("Unesite ime pacijenta.");

            prezime = unos.unos_ime_prezime("Unesite prezime pacijenta.");

            jmbg = unos.unos_jmbg("Unesite jmbg pacijenta.");

            br_zdr_kartona = unos.unos_br_zdr_kartona("Unesite broj zdravstvenog kartona pacijenta.");

            pacijent p = new pacijent(ime, prezime, jmbg, br_zdr_kartona);

            pacijent.Lista_pacijenata.Add(p);
        }

        static void izaberi_dr()
        {
            foreach(doktor d in doktor.Lista_doktora)
            {
                Console.WriteLine(d.Ime+" "+d.Prezime+" "+d.Specijalnost);
            }
            foreach(pacijent p in pacijent.Lista_pacijenata)
            {
                Console.WriteLine(p.Ime+" "+p.Prezime+" "+p.Jmbg+" "+p.Br_zdr_kartona);
            }
        }

        static void Main(string[] args)
        {
            int opcija;
            do
            {
                int brojac_iteracija=0;
                do
                {
                    if(brojac_iteracija>0) Console.WriteLine("Postovani, odaberite opciju od 1 do 6.");
                    interfejs();
                    opcija=int.Parse(Console.ReadLine());
                    brojac_iteracija++;
                }
                while(opcija<1 || opcija>6);

                switch(opcija)
                {
                    case 1:
                        unos_doktora();
                        break;
                    case 2:
                        unos_pacijenta();
                        break;
                    case 3:
                        izaberi_dr();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Izlazak iz programa... pritisnite bilo koje dugme.");
                        break;
                }
            }
            while(opcija!=6);

            Console.ReadKey();
        }
    }
}
