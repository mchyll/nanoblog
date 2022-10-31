using System;

namespace Mchyll.Nanotest
{
	interface ITest { }

	class TestA : ITest { }
	class TestB : ITest { }

	class Program
	{
		static void Main(string[] args)
		{
			var a = new TestA();
			var b = new TestB();
			ResolveGeneric(a);
			ResolveGeneric(b);
			Console.WriteLine();
			Resolve(a);
			Resolve(b);
		}

		static void Resolve(ITest test)
		{
			Console.WriteLine("Resolve(ITest test): " + test.GetType());
			Console.WriteLine("Interfaces: " + string.Join<Type>(", ", test.GetType().GetInterfaces()));
			Console.WriteLine("BaseType: " + test.GetType().BaseType);
		}

		static void ResolveGeneric<T>(T test) where T : ITest
		{
			Console.WriteLine("ResolveGeneric<T>(T test): " + test.GetType());
			Console.WriteLine("Interfaces: " + string.Join<Type>(", ", test.GetType().GetInterfaces()));
			Console.WriteLine("BaseType: " + test.GetType().BaseType);
		}
	}
}
