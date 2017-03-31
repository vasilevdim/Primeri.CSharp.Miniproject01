using System;
namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me();

		Colors.ForCLI _c = new Colors.ForCLI();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

		public UInput()
		{

		}

		public void SayHello()
		{
			_c.Default();
			Console.WriteLine("Dobre doshli v " + about.shortName + "\n" + about.version + "\n");
		}

		public void getUserCommands()
		{
			string _command = "";

			do
			{
				//Vzemane na komanda



				_c.Prompt(); Console.Write("$ ");
				_c.Command(); _command = Console.ReadLine();

				//Proverka za nalichni komandi

				if (_command.ToLower().Contains("iama")) _calc.F1.calc(_command);
				if (_command.ToLower().Contains("vagal")) _calc.F2.calc(_command);
				if (_command.ToLower().Contains("iagal")) _calc.F3.calc(_command);

				if (_command.ToLower().Contains ("pomosht") || 
				    _command.ToLower() == "p" )           		      _calc.commands();

				if (_command.ToLower().Contains("izchisti") ||
					_command.ToLower() == "i") 
				{

					Console.Clear();

					_c.Default();
					Console.WriteLine("Dobre doshli v " + about.shortName + "\n" + about.version + "\n");

				}

			} while (_command.ToLower() != "exit");

		}

		public void justTesting()
		{
			Console.WriteLine("Startirane na UserInput.UInput.justTesting()");
		}
	}
}

	

