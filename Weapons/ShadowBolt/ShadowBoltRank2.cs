using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBoltRank2 : ShadowBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/ShadowBolt/ShadowBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 2]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ShadowBoltProjRank2");
            item.damage = 22;
            item.mana = 4;
            item.value = Item.buyPrice(0, 1, 0, 0);
        }
    }
}
