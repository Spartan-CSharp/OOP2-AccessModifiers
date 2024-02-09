using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersLibrary
{
	internal class Dog : Pet
	{
		public void PrintProperties()
		{
			// PetName is accessible as it is public
			Console.WriteLine($"{PetName}");
			// NumberOfLegs is accessible as it is protected
			Console.WriteLine($"{NumberOfLegs}");
			// TailLength is accessible as it is internal
			Console.WriteLine($"{TailLength}");
			// LikesRubs is accessible as it is protected internal
			Console.WriteLine($"{LikesRubs}");
			// Cost is not accessible as it is private
			Console.WriteLine($"{Cost}");
			// PetOwner is accessible as it is private protected
			// PetOwner.FirstName is accessible as it is public
			Console.WriteLine($"{PetOwner.FirstName}");
		}
	}
}
