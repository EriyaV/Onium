using OniumMod.UI;
using ReLogic.Graphics;
using Terraria.ModLoader;
using Terraria.UI;

namespace OniumMod
{
	public class OniumMod : Mod
	{
		internal static DynamicSpriteFont exampleFont;
		private UserInterface _exampleUserInterface;
		private UserInterface _exampleResourceBarUserInterface;

		internal UserInterface ExamplePersonUserInterface;
		internal ExampleUI ExampleUI;
		internal ExampleResourceBar ExampleResourceBar;

		// Your mod instance has a Logger field, use it.
		// OPTIONAL: You can create your own logger this way, recommended is a custom logging class if you do a lot of logging
		// You need to reference the log4net library to do this, this can be found in the tModLoader repository
		// inside the references folder. You do not have to add this to build.txt as tML has it natively.
		// internal ILog Logging = LogManager.GetLogger("ExampleMod");

		public OniumMod()
		{
			// By default, all Autoload properties are True. You only need to change this if you know what you are doing.
			//Properties = new ModProperties()
			//{
			//	Autoload = true,
			//	AutoloadGores = true,
			//	AutoloadSounds = true,
			//	AutoloadBackgrounds = true
			//};
		}

		public override void Load()
		{
			// Will show up in client.log under the ExampleMod name
			Logger.InfoFormat("{0} onium logging", Name);
			// In older tModLoader versions we used: ErrorLogger.Log("blabla");
			// Replace that with above

			
				if (FontExists("Fonts/ExampleFont"))
					exampleFont = GetFont("Fonts/ExampleFont");

				// Custom UI
				ExampleUI = new ExampleUI();
				ExampleUI.Activate();
				_exampleUserInterface = new UserInterface();
				_exampleUserInterface.SetState(ExampleUI);

				// Custom Resource Bar
				ExampleResourceBar = new ExampleResourceBar();
				_exampleResourceBarUserInterface = new UserInterface();
				_exampleResourceBarUserInterface.SetState(ExampleResourceBar);

				// UserInterface can only show 1 UIState at a time. If you want different "pages" for a UI, switch between UIStates on the same UserInterface instance. 
				// We want both the Coin counter and the Example Person UI to be independent and coexist simultaneously, so we have them each in their own UserInterface.
				ExamplePersonUserInterface = new UserInterface();
				// We will call .SetState later in ExamplePerson.OnChatButtonClicked
			}

		}
	}