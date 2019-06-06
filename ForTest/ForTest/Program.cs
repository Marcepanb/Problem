using System;

namespace ForTest {

	class SomeClass<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable {
		// T może być tylko numeryczne aka int, char, byte
	}

	interface INumeral<T> : IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable {
		// pomocniczy interface dzięki któremu mogę skrócić pisanie
	}

	class SomeOtherClass<T> where T : struct, INumeral<T> {
		// klasa z użytym skrótem
	}

	class Program {
		static void Main(string[] args) {

			SomeClass<int> someClass = new SomeClass<int>();                // działa dobrze
			SomeClass<string> someClass = new SomeClass<string>();			// zgodnie z potrzebą T musi być numeryczne 
			SomeOtherClass<int> someOtherClass = new SomeOtherClass<int>();	// ale użycie skrótu nie działa 
		}
	}
}
