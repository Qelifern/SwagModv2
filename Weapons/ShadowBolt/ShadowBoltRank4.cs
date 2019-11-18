using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBoltRank4 : ShadowBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/ShadowBolt/ShadowBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 4]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ShadowBoltProjRank4");
            item.damage = 44;
            item.mana = 9;
            item.value = Item.buyPrice(0, 7, 50, 0);
        }
    }
}
