using System;

namespace Calculator
{
	class MainClass
	{
		//Definirane na biblioteki
		public UserInput.UInput uInput = new UserInput.UInput(); 

		public static void Main(string[] args)
		{
			
			MainClass _program = new MainClass();
			_program.uInput.getUserCommands();
		}

	}
}
