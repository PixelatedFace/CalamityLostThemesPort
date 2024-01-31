using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLostThemesPort.Items.MusicBoxes;
using CalamityLostThemesPort.Tiles.MusicBoxes;
using CalamityLostThemesPort.SceneEffects;
using System;

namespace CalamityLostThemesPort
{
	public class CalamityLostThemesPort : Mod
	{
        internal Mod clamExtraMusic = null;
        public static CalamityLostThemesPort instance;
        public override void Load()
        {
            
            instance = this;
            ModLoader.TryGetMod("ClamExtraMusic", out clamExtraMusic);



            
        }

        public int GetMusic(string name){ 
            if(clamExtraMusic != null){
                return MusicLoader.GetMusicSlot(clamExtraMusic, "Assets/Music/"+name);
            }
            return MusicLoader.GetMusicSlot(this, "Sounds/Music/Planetoids");
        }

        

    
    }	
}