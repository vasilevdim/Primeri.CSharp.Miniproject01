using System;
namespace Calculations
{
	/// <summary>
	/// class za formula za obiknovena stroitelna iama (Formula01)
	/// </summary>

	public class Formula01

	{
		//Biblioteki
		private Colors.ForCLI _c = new Colors.ForCLI ();




		public Formula01 ()  //Formula za obiknovena stroitelna iama
		{
		}

		//Parsvane
		public void calc(string _userInput)
		{
			try
			{
				string[] param = _userInput.Split(' ');
				if (param.Length > 1 && _userInput.Contains("-p"))
				{
					//Pomosht za komandata

					help();

				}

				if (param.Length > 1 && !_userInput.Contains("-p"))
				{

					//Izchislenia
					double _result = 0;
					if (runCalculations(param, out _result))
					{
						_c.Default();	Console.WriteLine("Obemat na stroitelnata iama e: ");
						_c.Result();	Console.WriteLine(_result.ToString("N2"));
						_c.Default(); Console.WriteLine("m3\n");
					}
					else {
						_c.Default();	Console.WriteLine("Ima greshno vavedeni parametri.Mojete da proverite sintaksisa s parametara '-p'\n");
					}
				}
			}
			catch { }

		}
		//Izchislenia i izpisvane
		private bool runCalculations(string[] _param, out double _result)
		{
			try
			{
				//_param [0] == ime na komandata
				double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0, _h = 0;

				Double.TryParse (_param[1], out _a1);
				Double.TryParse (_param[2], out _b1);
				Double.TryParse (_param[3], out _a2);
				Double.TryParse (_param[4], out _b2);
				Double.TryParse (_param[5], out _h);

				double F1 = _a1 * _b1, F2 = _a2 * _b2;
				_result = _h * (F1 + F2) / 2;

				return true;
			}
			catch { }
			_result = 0;
			return false;
		}
		//Pomosht za komandata
		private void help()
		{

			_c.Result(); Console.Write("[iama]");
			_c.Default(); Console.WriteLine("-komanda za presmiatane na stroitelna iama");

			_c.Command(); Console.Write("[parametri]");
			_c.Default(); Console.WriteLine(" a1 b1 a2 b2 h\n");

			_c.Command(); Console.Write("[a1 i b1]");
			_c.Default(); Console.WriteLine(" - shirina i daljina na gornata strana na izkopa");

			_c.Command(); Console.Write("[a2 i b2]");
			_c.Default(); Console.WriteLine("- shirina i daljina na dolnata strana na izkopa");

			_c.Command(); Console.Write("[h]");
			_c.Default(); Console.WriteLine(" - visochina na izkopa\n");


		}

	}
}
