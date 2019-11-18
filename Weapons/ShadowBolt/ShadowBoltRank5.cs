using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBoltRank5 : ShadowBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/ShadowBolt/ShadowBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 5]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ShadowBoltProjRank5");
            item.damage = 50;
            item.mana = 14;
            item.useTime = 25;
            item.useAnimation = 25;
            item.value = Item.buyPrice(0, 10, 0, 0);
        }
    }
}
