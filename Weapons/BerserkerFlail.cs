using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class BerserkerFlail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Breaker");
        }

        public override void SetDefaults()
        {
            item.autoReuse = false;
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.rare = 9;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 5;
            item.knockBack = 4.0f;
            item.melee = true;
            item.damage = 152;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BerserkerFlailProj");
            item.shootSpeed = 20f;
            item.noUseGraphic = true;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Flairon);
            r.AddIngredient(ItemID.TempestStaff);
            r.AddIngredient(ItemID.FragmentSolar, 20);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
