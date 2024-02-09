using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersLibrary
{
	internal class Pet
	{
		public string PetName
		{
			get; set;
		}

		protected int NumberOfLegs
		{
			get; set;
		}

		internal double TailLength
		{
			get; set;
		}

		protected internal bool LikesRubs
		{
			get; set;
		}

		private decimal Cost
		{
			get; set;
		}

		public Person PetOwner
		{
			get; set;
		} = new Person();

		public void GoForAWalk()
		{
			// FirstName is accessible as it is public
			Console.WriteLine($"{PetOwner.FirstName} takes {PetName} for a walk.");
		}

		protected void TakesABath()
		{
			// LastName not accessible as it is protected
			Console.WriteLine($"{PetOwner.LastName} gives {PetName} a bath.");
		}

		internal bool IsOwnerOldEnough()
		{
			// Age is accessible as it is internal
			return PetOwner.Age >= 12;
		}

		protected internal void GivesRubs()
		{
			// NetWorth is accessible as it is protected internal
			if ( LikesRubs && PetOwner.NetWorth > 3.00M )
			{
				Console.WriteLine($"{PetName} gets lots of rubs");
			}
		}

		private void DoesBusiness()
		{
			Console.WriteLine("Doing do do.");
			// SSN is not accessible as it is private
			Console.WriteLine($"{PetOwner.SSN}");
		}

		private protected void GoToSleep()
		{
			// Height is not accessible as it is private protected
			Console.WriteLine($"{PetName} sleeps in a {PetOwner.Height} bed.");
		}
	}
}
