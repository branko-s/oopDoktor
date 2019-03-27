using System;
using System.Collections.Generic;
namespace oopDoktor_ns
{
    abstract class pregled
    {
        private DateTime datum_vreme;
        protected pregled(DateTime dv)
        {
           datum_vreme=dv;
        }
    }

    class krvni_pritisak:pregled
    {
        private int g_vred;
        private int d_vred;
        private int puls;
        public krvni_pritisak(DateTime dv):base(dv)
        {
            g_vred=0;
            d_vred=0;
            puls=0;
        }
        public krvni_pritisak(DateTime dv, int gvr, int dvr, int p):base(dv)
        {
            g_vred=gvr;
            d_vred=dvr;
            puls=p;
        }
    }

    class secer:pregled
    {
        private double vrednost;
        int vreme_poslednjeg_obroka;
        public secer(DateTime dv):base(dv)
        {
            vrednost=0;
            vreme_poslednjeg_obroka=0;
        }
        public secer(DateTime dv, double v, int vpo):base(dv)
        {
            vrednost=v;
            vreme_poslednjeg_obroka=vpo;
        }
    }

    class holesterol:pregled
    {
        private double vrednost;
        int vreme_poslednjeg_obroka;
        public holesterol(DateTime dv):base(dv)
        {
            vrednost=0;
            vreme_poslednjeg_obroka=0;
        }
        public holesterol(DateTime dv, double v, int vpo):base(dv)
        {
            vrednost=v;
            vreme_poslednjeg_obroka=vpo;
        }
    }

}