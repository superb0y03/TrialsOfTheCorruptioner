using Terraria.ModLoader;

namespace TrialsOfTheCorruptioner {

	class TrialsOfTheCorruptioner : Mod {
		public TrialsOfTheCorruptioner() {
			Properties = new ModProperties() {
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}

}
