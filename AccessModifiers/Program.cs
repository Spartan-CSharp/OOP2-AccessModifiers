using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessModifiersLibrary;

namespace AccessModifiers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			Manager manager = new Manager();
			CEO ceo = new CEO();
			// Class Pet not accessible as it is internal
			Pet cat = new Pet();
			// Class Dog not accessible as it is internal
			Dog scruffy = new Dog();

			// person.FirstName is accessible as it is public
			Console.WriteLine($"{person.FirstName}");
			// person.LastName is not accessible as it is protected
			Console.WriteLine($"{person.LastName}");
			// person.Age is not accessible as it is internal
			Console.WriteLine($"{person.Age}");
			// person.NetWorth is not accessible as it is protected internal
			Console.WriteLine($"{person.NetWorth}");
			// person.SSN is not accessible as it is private
			Console.WriteLine($"{person.SSN}");
			// person.Height is not accessible as it is private protected
			Console.WriteLine($"{person.Height}");

			// manager.FirstName is accessible as it is public
			Console.WriteLine($"{manager.FirstName}");
			// manager.LastName is not accessible as it is protected
			Console.WriteLine($"{manager.LastName}");
			// manager.Age is not accessible as it is internal
			Console.WriteLine($"{manager.Age}");
			// manager.NetWorth is not accessible as it is protected internal
			Console.WriteLine($"{manager.NetWorth}");
			// manager.SSN is not accessible as it is private
			Console.WriteLine($"{manager.SSN}");
			// manager.Height is not accessible as it is private protected
			Console.WriteLine($"{manager.Height}");
			// manager.PrintProperties is accessible as it is public
			manager.PrintProperties();

			// ceo.FirstName is accessible as it is public
			Console.WriteLine($"{ceo.FirstName}");
			// ceo.LastName is not accessible as it is protected
			Console.WriteLine($"{ceo.LastName}");
			// ceo.Age is not accessible as it is internal
			Console.WriteLine($"{ceo.Age}");
			// ceo.NetWorth is not accessible as it is protected internal
			Console.WriteLine($"{ceo.NetWorth}");
			// ceo.SSN is not accessible as it is private
			Console.WriteLine($"{ceo.SSN}");
			// ceo.Height is not accessible as it is private protected
			Console.WriteLine($"{ceo.Height}");
			// ceo.PrintProperties is accessible as it is public
			ceo.PrintProperties();

			_ = Console.ReadLine();
		}
	}
}
