using System;
using System.IO;
using System.Globalization;

namespace oopDoktor_ns
{
    class logovanje
    {
        private static logovanje instanca;
        protected logovanje(){}
        public static logovanje singlton()
        {
            if(instanca==null) instanca=new logovanje();
            return instanca;
        }
        public void log(string akcija)
        {
            DateTime dv=DateTime.Now;
            using(StreamWriter sw=new StreamWriter("logovanje.txt", true))
            {
                sw.WriteLine("["+dv.ToShortDateString()+"]"+"["+dv.ToShortTimeString()+"]"+"["+akcija+"]");
            }
        }
    }
}