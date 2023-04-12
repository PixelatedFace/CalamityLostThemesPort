using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityLostThemesPort
{
	class CalamityLostThemesConfig : ModConfig{
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static CalamityLostThemesConfig Instance;

        [Label("Planetoid Music Priority")]
        [Tooltip("Sets the Priority of the Planetoids theme")]
        public SceneEffectPriority planetoidPriorirty;

    }

}