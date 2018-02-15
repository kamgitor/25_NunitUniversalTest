// This is the main DLL file.

#include "stdafx.h"

// #include "UniversalTestCpp.h"


// UWAGA zeby to dzialalo trzeba w ustawieniach zmienic CLR support na Safe MSIL
// Project/Properties
// ***********************************************************************************************************
namespace UniversalTestCpp
{

	public ref class Program
	{

		// ***********************************************************************************************************
		public:
		static int add(int a, int b)
		{
			return a + b;

		}   // add


		// ***********************************************************************************************************
		public:
		static int subtract(int a, int b)
		{
			return a - b;

		}   // subtract


		// ***********************************************************************************************************
		public:
		static int pow(int a)
		{
			return a * a;

		}   // subtract


	};

}	// namespace UniversalTestCpp



// ***********************************************************************************************************
// ***********************************************************************************************************
int main(array<System::String ^> ^args)
{
	// cout << "Hello World";
    // Console::WriteLine(L"Hello World");

}	// main

