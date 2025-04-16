using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ALMusic
{
	public class ALMusic : Mod
	{
        public static ALMusic Instance;

        internal Mod AL = null;

        public ALMusic() => Instance = this;

        public override void Load()
        {
            AL = null;
            ModLoader.TryGetMod("MultidimensionMod", out AL);
        }

        public override void Unload()
        {
            AL = null;
        }
    }
}
