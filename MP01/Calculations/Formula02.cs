using System;
namespace Calculations
{
	public class Formula02
	{
		public Formula02()
		{
		}

		public void calc(string _input)
		{
			try
			{

				string[] param = _input.Split(' ');
				if (param.Length > 1 && _input.ToLower().Contains("-p"))
				{
					help();
				}

				if (param.Length == 4)
				{
					double result = 0;
					if (runCalculate(param, out result))



						Console.Write("Obemat na vdlabnatiat agal e:");
					Console.Write(result.ToString("N2"));
					Console.WriteLine(" m3\n ");

				}
				else
				{
					Console.WriteLine("Ima greshno vavedeni parametri. S parametara '-p' mojete\n da vidite sintaksisa na komandata.\n");

				}

			}

			catch
			{

			}


		}


		private bool runCalculate(string[] _param, out double _result)
		{
			try
			{
				double a = 0; Double.TryParse(_param[1], out a);
				double b = 0; Double.TryParse(_param[2], out b);
				double h = 0; Double.TryParse(_param[3], out h);

				_result = a * b * h / 3;

				return true;
			}
			catch
			{
			}

			_result = 0;
			return false;

		}
		private void help()
		{
			Console.Write("[vagal]");
			Console.WriteLine("-vdlabnat agal");

			Console.Write("parametri:");
			Console.WriteLine("a, b i h\n");

			Console.Write(" a i b");
			Console.WriteLine("shirina i daljina");

			Console.Write(" h ");
			Console.WriteLine("- visochina\n");


		}

	}
}

