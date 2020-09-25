﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
	class Megrendeles
	{
		
		private string datum;

		public string DATUM
		{
			get { return datum; }
			set { datum = value; }
		}

		private string rendelesszam;

		public string RENDELESSZAM
		{
			get { return rendelesszam; }
			set { rendelesszam = value; }
		}

		private string email;

		public string EMAIL
		{
			get { return email; }
			set { email = value; }
		}

		private List<Tetel> tetelek;
		internal object termekek;

		public void TetelHozzaad(string kod, int db)
		{
			tetelek.Add(new Tetel(kod, db));
		}


		public Megrendeles(string datum, string rendelesszam, string email)
		{
			
			this.datum = datum;
			this.rendelesszam = rendelesszam;
			this.email = email;
			tetelek = new List<Tetel>();
		}


	}
}
