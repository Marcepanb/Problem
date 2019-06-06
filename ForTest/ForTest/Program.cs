using System;

namespace ForTest {
	class Program {
		static void Main(string[] args) {

			SomeClass<int> someClass = new SomeClass<int>();
			SomeOtherClass<int> someOtherClass = new SomeOtherClass<int>();
		}
	}


	interface INumeral<T> : IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable { }

	class SomeClass<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable { }

	class SomeOtherClass<T> where T : struct, INumeral<T> { }


}