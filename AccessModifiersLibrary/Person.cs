﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersLibrary
{
	public class Person
	{
		public string FirstName
		{
			get; set;
		}


		protected string LastName
		{
			get; set;
		}

		internal int Age
		{
			get; set;
		}

		protected internal decimal NetWorth
		{
			get; set;
		}

		private string SSN
		{
			get; set;
		}

		private protected double Height
		{
			get; set;
		}
	}
}
