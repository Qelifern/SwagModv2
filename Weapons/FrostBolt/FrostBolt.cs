using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.FrostBolt
{
    public class FrostBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 1]");
            Tooltip.SetDefault("Hurls a frozen ball of ice at your target.\nHas a chance to increase critical strike chance with magic by 50% on your next spell, lasts 6 seconds.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 10;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 4.0f;
            item.magic = true;
            item.shoot = mod.ProjectileType("FrostBoltProj");
            item.shootSpeed = 3.2f;
            item.damage = 8;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item20;
            item.mana = 1;
            item.value = Item.buyPrice(0, 0, 2, 0);
        }
    }
}
