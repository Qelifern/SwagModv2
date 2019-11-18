using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBoltRank7 : ShadowBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/ShadowBolt/ShadowBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 7]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ShadowBoltProjRank7");
            item.damage = 79;
            item.mana = 24;
            item.useTime = 22;
            item.useAnimation = 22;
            item.value = Item.buyPrice(0, 20, 0, 0);
        }
    }
}
