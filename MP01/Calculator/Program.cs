using System;

namespace Calculator
{
	class MainClass
	{
		//Definirane na biblioteki
		public UserInput.UInput uInput = new UserInput.UInput();
		public About.Me about = new About.Me();

		public static void Main(string[] args)
		{
			
			MainClass _program = new MainClass();
			//Formatirane na programata
			Console.Title = _program.about.shortName + ", " + _program.about.version;

			//Startirane na programata
			_program.uInput.SayHello();
			_program.uInput.getUserCommands();
		}

	}
}
