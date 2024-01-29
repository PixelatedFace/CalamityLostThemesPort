using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityLostThemesPort
{
	class CalamityLostThemesConfig : ModConfig{
        public override ConfigScope Mode => ConfigScope.ClientSide;
       

        [DefaultValue(true)]
        [ReloadRequired]
        public bool planetoidThemeChange;

        [DefaultValue(SceneEffectPriority.Event)]
        public SceneEffectPriority planetoidPriority;

        

    }

}