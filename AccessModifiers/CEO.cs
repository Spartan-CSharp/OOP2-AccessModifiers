using System;

using AccessModifiersLibrary;

namespace AccessModifiers
{
	public class CEO : Person
	{
		public void PrintProperties()
		{
			// FirstName is accessible as it is public
			Console.WriteLine($"{FirstName}");
			// LastName is accessible as it is protected
			Console.WriteLine($"{LastName}");
			// Age is not accessible as it is internal
			Console.WriteLine($"{Age}");
			// NetWorth is accessible as it is protected internal
			Console.WriteLine($"{NetWorth}");
			// SSN is not accessible as it is private
			Console.WriteLine($"{SSN}");
			// Height is not accessible as it is private protected
			Console.WriteLine($"{Height}");
		}
	}
}
