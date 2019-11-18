using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ShadowBolt
{
    public class ShadowBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 1]");
            Tooltip.SetDefault("Hurls a shadowy ball of death at your target.\nMay drain life from enemies.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 10;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.knockBack = 4.0f;
            item.magic = true;
            item.shoot = mod.ProjectileType("ShadowBoltProj");
            item.shootSpeed = 3.2f;
            item.damage = 10;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item43;
            item.mana = 2;
            item.value = Item.buyPrice(0, 0, 2, 0);
        }
    }
}
