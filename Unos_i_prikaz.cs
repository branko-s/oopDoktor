using System;

namespace oopDoktor_ns
{
    static class unos
    {
        static public string unos_ime_prezime(string poruka)
        {
            string temp1, temp2;
            int temp3;
            bool pravilno;

            Console.WriteLine(poruka);
            do
            {
                pravilno=true;
                temp1=Console.ReadLine();
            
                foreach(char c in temp1)
                {
                    temp2=c.ToString();
                    if(int.TryParse(temp2, out temp3))
                    {
                        Console.WriteLine("Unos je nepravilan. Molimo vas da ne unosite brojeve i da ponovite unos:");
                        pravilno=false;
                        break;
                    }
                }

                if(temp1=="")
                {
                    Console.WriteLine("Niste uneli podatak. Molimo vas ponovite unos:");
                    pravilno=false;
                }
            }
            while(pravilno==false);
            return temp1;
        }
        static public long unos_jmbg(string poruka)
        {
            long broj;
            bool pravilno;

            Console.WriteLine(poruka);

            do
            {
            pravilno=false;
            if(long.TryParse(Console.ReadLine(), out broj))
            {
                if(broj/10000000000000==0 && broj/1000000000000!=0)
                {
                    pravilno=true;
                }
                else Console.WriteLine("Nepravilan unos. Jmbg se sastoji od 13 cifara. Molimo vas ponovite unos.");
            }
            else Console.WriteLine("Nepravilan unos. Jmbg se sastoji od 13 cifara. Molimo vas ponovite unos.");
            }
            while(pravilno==false);
            
            return broj;
        }

        static public long unos_br_zdr_kartona(string poruka)
        {
            long broj;
            bool pravilno;

            Console.WriteLine(poruka);

            do
            {
            pravilno=false;
            if(long.TryParse(Console.ReadLine(), out broj))
            {
                if(broj/100000000==0 && broj/10000000!=0)
                {
                    pravilno=true;
                }
                else Console.WriteLine("Nepravilan unos. Broj zdravstvenog kartona se sastoji od 8 cifara. Molimo vas ponovite unos.");
            }
            else Console.WriteLine("Nepravilan unos. Broj zdravstvenog kartona se sastoji od 8 cifara. Molimo vas ponovite unos.");
            }
            while(pravilno==false);
            
            return broj;
        }


    }
    static class prikaz
    {
        static public void prikazi(osoba o)
        {
            Console.WriteLine("Lista "+typeof(o)+"-a:");
            foreach(osoba o in o.Lista_pacijenata)
        }
    }
}