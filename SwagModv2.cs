using Terraria.ModLoader;

namespace SwagModv2
{
	class SwagModv2 : Mod
	{
		public SwagModv2()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
