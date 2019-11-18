using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class IllustriousKnives : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Illustrious Knives");
            Tooltip.SetDefault("Rapidly throw homing life-stealing daggers");
        }

        public override void SetDefaults()
        {
            item.autoReuse = true;
            item.useStyle = 1;
            item.shootSpeed = 15f;
            item.shoot = mod.ProjectileType("IllustriousKnivesProj");
            item.damage = 44;
            item.width = 16;
            item.height = 16;
            item.UseSound = SoundID.Item39;
            item.useAnimation = 16;
            item.useTime = 16;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 65, 0, 0);
            item.knockBack = 2.75f;
            item.melee = true;
            item.rare = 9;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(24)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.VampireKnives);
            r.AddIngredient(ItemID.MagicDagger);
            r.AddIngredient(ItemID.SoulofMight, 15);
            r.AddIngredient(ItemID.HallowedBar, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
