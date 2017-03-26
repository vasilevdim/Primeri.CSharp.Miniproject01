using System;
namespace Calculations
{
	public class Formula01
	{
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

				}

				if (param.Length > 1 && !_userInput.Contains("-p"))
				{

					//Izchislenia
					double _result = 0;
					if (runCalculations(param, out _result))
					{
						Console.WriteLine("Obemat na stroitelnata iama e: ");
						Console.WriteLine(_result.ToString("N2"));
					}
					else {
						Console.WriteLine("Ima greshno vavedeni parametri.Mojete da proverite sintaksisa s parametara '-p'");
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
	}
}
