using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBoltRank6 : ShadowBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/ShadowBolt/ShadowBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 6]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ShadowBoltProjRank6");
            item.damage = 68;
            item.mana = 17;
            item.useTime = 25;
            item.useAnimation = 25;
            item.value = Item.buyPrice(0, 15, 0, 0);
        }
    }
}
