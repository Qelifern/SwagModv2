using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class SwagSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Sword");
            Tooltip.SetDefault("Gives life on CRITICAL enemy hits.\nFires a projectile that inflicts poison debuff on enemy hits.");
        }

        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 128;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 33, 21, 61);
            item.rare = 10;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.crit += 20;
            item.knockBack = 7.0f;
            item.melee = true;
            item.shoot = mod.ProjectileType("SwagSwordProj");
            item.shootSpeed = 10f;
            item.damage = 584;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
        }



        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (crit)
            {
                int shit = damage / Main.rand.Next(25, 50);
                player.HealEffect(shit);
                player.statLife += shit;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwagiantiumBar"), 20);
            r.AddIngredient(ItemID.RazorbladeTyphoon);
            r.AddIngredient(ItemID.TerraBlade);
            r.AddIngredient(ItemID.SolarEruption);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
