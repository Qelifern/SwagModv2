using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class InfluxReaper : ModItem
    {
        public override string Texture { get { return "Terraria/Item_" + ItemID.InfluxWaver; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Influx Reaper");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 42;
            item.maxStack = 1;
            item.rare = 7;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 3.2f;
            item.melee = true;
            item.damage = 88;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.shoot = ProjectileID.InfluxWaver;
            item.shootSpeed = 16f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.InfluxWaver);
            r.AddIngredient(ItemID.VortexBeater);
            r.AddIngredient(ItemID.FragmentSolar, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
