using System;
namespace Calculations
{
	public class Formula02
	{
		//Formula za vdlabnat agal

		Colors.ForCLI _cl = new Colors.ForCLI();

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



						_cl.Default();	Console.Write("Obemat na vdlabnatiat agal e:");
					_cl.Result ();     Console.Write(result.ToString("N2"));
					_cl.Default ();     Console.WriteLine(" m3\n ");

				}
				else
				{
					_cl.Default (); Console.WriteLine("Ima greshno vavedeni parametri. S parametara '-p' mojete\n da vidite sintaksisa na komandata.\n");

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
			_cl.Result();	Console.Write("[vagal]");
			_cl.Default();	Console.WriteLine("-vdlabnat agal");

			_cl.Command();	Console.Write("parametri:");
			_cl.Default ();	Console.WriteLine ("a, b i h\n");

			_cl.Command();	Console.Write(" a i b");
			_cl.Default (); Console.WriteLine("shirina i daljina");

			_cl.Command();	Console.Write(" h ");
			_cl.Default (); Console.WriteLine("- visochina\n");


		}

	}
}

