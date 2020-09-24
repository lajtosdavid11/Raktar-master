﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Termek
    {
        private string kod;
        public string KOD {


            get { return kod; }
            set { kod = value; }
        }
        private string nev;

        public string Nev { get { return nev; } set { nev = value; } }

        private int ar;



        public int AR
        {
            get { return ar; }
            set { ar = value; }
        }
        private int db;

        public int DB
        {
            get { return db; }
            set { db = value; }
        }



        public Termek (string kod, string nev, int ar,int db )
        {
            this.kod = kod;
            this.nev = alakit(nev);
            this.ar = ar;
            this.db = db;
            


        }

        private string alakit(string szoveg)
        {
            string tmp = "";
            
            string ekezetes = "áéíóöőüúű";
            string mire = "aeiooouuu";
            
            

            for (int i = 0; i < szoveg.Length; i++)
            {
                int hol = ekezetes.IndexOf(szoveg[i]);
                if (hol > -1)
                {
                    tmp += mire[hol];
                }
                else
                {
                    tmp += szoveg[i];
                }

            }
            

            return tmp;
        }


    }
}
