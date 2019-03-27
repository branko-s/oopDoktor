using System;
using System.Collections.Generic;
namespace oopDoktor_ns
{
    abstract class osoba
    {
        private string ime;
        private string prezime;
        private long jmbg;
        protected osoba(string i, string p, long j)
        {
            ime=i;
            prezime=p;
            jmbg=j;
        }
        public string Ime { get => ime;}
        public string Prezime { get => prezime;}
        public long Jmbg { get => jmbg;}

        abstract public void izaberi_dr(doktor d, pacijent p);
        abstract public void zakazi_pregled(pacijent p);
    }

    class doktor:osoba
    {
        private string specijalnost;
        private List<pacijent> pacijenti;
        private static List<doktor> lista_doktora=new List<doktor>();

        internal List<pacijent> Pacijenti { get => pacijenti;}
        public string Specijalnost { get => specijalnost;}
        internal static List<doktor> Lista_doktora { get => lista_doktora; set => lista_doktora = value; }

        public doktor(string i, string p, long j, string s):base(i, p, j)
        {
            specijalnost=s;
            pacijenti=new List<pacijent>();
            Console.WriteLine("Dodat je doktor"+" "+Ime+" "+Prezime+" "+Jmbg+".");
            logovanje l=logovanje.singlton();
            l.log("Dodat je doktor"+" "+Ime+" "+Prezime+" "+Jmbg+".");
        }
         public override void izaberi_dr(doktor d, pacijent p)
        {
            pacijenti.Add(p);
            p.izaberi_dr(d, p);
        }
        public override void zakazi_pregled(pacijent p)
        {
           p.zakazi_pregled(p);
        }
    }

    class pacijent:osoba
    {
        private long br_zdr_kartona;
        private doktor izabrani_dr;
        private List<pregled> zak_pregledi;
        private static List<pacijent> lista_pacijenata=new List<pacijent>();
        public pacijent(string i, string p, long j, long bzk):base(i, p, j)
        {
            br_zdr_kartona=bzk;
            izabrani_dr=null;
            zak_pregledi=new List<pregled>();
            Console.WriteLine("Dodat je pacijent"+" "+Ime+" "+Prezime+" "+Jmbg+".");
            logovanje l=logovanje.singlton();
            l.log("Dodat je pacijent"+" "+Ime+" "+Prezime+" "+Jmbg+".");
        }
        public long Br_zdr_kartona { get => br_zdr_kartona;}
        internal List<pregled> Zak_pregledi { get => zak_pregledi;}
        internal static List<pacijent> Lista_pacijenata { get => lista_pacijenata; set => lista_pacijenata = value; }

        public override void izaberi_dr(doktor d, pacijent p)
        {
            izabrani_dr=d;
            Console.WriteLine(Ime+" "+Prezime+" : izabran je doktor "+d.Ime+" "+d.Prezime+".");
        }
        public override void zakazi_pregled(pacijent p)
        {
            int opcija;
            DateTime dv=new DateTime();
            do
            {
            Console.WriteLine("Odaberite pregled:");
            Console.WriteLine("\t1. Merenje secera u krvi.");
            Console.WriteLine("\t2. Merenje holesterola.");
            Console.WriteLine("\t3. Merenje krvnog pritiska");
            opcija=int.Parse(Console.ReadLine());
            }
            while(opcija!=1 && opcija!=2 && opcija!=3);
            switch(opcija)
            {
                case 1:
                    secer s=new secer(dv);
                    zak_pregledi.Add(s);
                    Console.WriteLine(Ime+" "+Prezime+": Zakazan je pregled merenja secera u krvi.");
                    break;
                case 2:
                    holesterol h=new holesterol(dv);
                    Console.WriteLine(Ime+" "+Prezime+": Zakazan je pregled merenja holesterola.");
                    zak_pregledi.Add(h);
                    break;
                case 3:
                    krvni_pritisak kp=new krvni_pritisak(dv);
                    Console.WriteLine(Ime+" "+Prezime+": Zakazan je pregled merenja krvnog pritiska.");
                    zak_pregledi.Add(kp);
                    break;
            }
        }
    }
}