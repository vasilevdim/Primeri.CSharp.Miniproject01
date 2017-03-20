using System;
namespace UserInput
{
	public class UInput
	{
		public UInput()
		{
		}

		public void getUserCommands()
		{
			string _command = "";

			do {
				//Vzemane na komanda



				Console.Write ("$ ");
				_command = Console.ReadLine ();
				//Proverka za nalichni komandi
				if (_command.ToLower().Contains("command1")) Console.WriteLine("Startirana e komanda 1\n");
				if (_command.ToLower().Contains("command2")) Console.WriteLine("Startirana e komanda 2\n");
				if (_command.ToLower().Contains("command3")) Console.WriteLine("Startirana e komanda 3\n");


			}while (_command.ToLower() != "exit");

		}

		public void justTesting()
		{
			Console.WriteLine ("Startirane na UserInput.UInput.justTesting()");
		}

	}
}
