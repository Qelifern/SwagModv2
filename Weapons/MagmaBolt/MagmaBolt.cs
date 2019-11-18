using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;


namespace SwagModv2.Weapons.MagmaBolt
{
    public class MagmaBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magma Bolt");
            Tooltip.SetDefault("Casts a moving bolt of magma");
        }

        public override void SetDefaults()
        {
            item.autoReuse = true;
            item.rare = 3;
            item.mana = 12;
            item.UseSound = SoundID.Item20;
            item.useStyle = 5;
            item.damage = 24;
            item.useAnimation = 17;
            item.useTime = 17;
            item.width = 24;
            item.height = 28;
            item.shoot = mod.ProjectileType("MagmaBoltProj");
            item.scale = 0.9f;
            item.shootSpeed = 6.5f;
            item.knockBack = 5f;
            item.magic = true;
            item.value = 50000;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.WaterBolt);
            r.AddIngredient(ItemID.Obsidian, 20);
            r.AddIngredient(ItemID.Fireblossom, 5);
            r.AddIngredient(ItemID.LavaBucket);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
