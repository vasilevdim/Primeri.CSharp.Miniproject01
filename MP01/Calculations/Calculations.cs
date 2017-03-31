using System;
namespace Calculations
{
	public class MainLibrary
	{
		//Definizii

		public Formula01 F1 = new Formula01();
		public Formula02 F2 = new Formula02();
		public Formula03 F3 = new Formula03();


		//Biblioteki
		private Colors.ForCLI _cl = new Colors.ForCLI ();

		public MainLibrary()
		{
		}

		public void commands()
		{
			_cl.Default(); Console.WriteLine("Nalichni komandi\n");

			_cl.Command(); Console.Write("[iama]");

			_cl.Default(); Console.WriteLine("-presmiatane na stroitelna iama");

			_cl.Command(); Console.Write("[vagal]");

			_cl.Default(); Console.WriteLine("-presmiatane na vdlabnat agal");

			_cl.Command(); Console.Write("[iagal]");

			_cl.Default(); Console.WriteLine("-presmiatane na izpaknal agal\n");


		}
	
	
	}
}
