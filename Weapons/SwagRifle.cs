using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class SwagRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Rifle");
            Tooltip.SetDefault("60% chance to not consume ammo.\nEach time Swag Rifle doesn't use ammo it has a chance to give life.");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 18;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 14, 33, 29);
            item.rare = 10;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.crit += 50;
            item.knockBack = 4.0f;
            item.ranged = true;
            item.shoot = 10;
            item.shootSpeed = 25f;
            item.damage = 187;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-12, -4);
        }

        public override bool ConsumeAmmo(Player player)
        {
            int shit = Main.rand.Next(100);
            if (shit < 60)
            {
                int shit2 = Main.rand.Next(4);
                if (shit2 == 0)
                {
                    int shit3 = Main.rand.Next(1, 10);
                    player.HealEffect(shit3);
                    player.statLife += shit3;
                }
                return false;
            }
            return base.ConsumeAmmo(player);
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwagiantiumBar"), 20);
            r.AddIngredient(ItemID.SDMG);
            r.AddIngredient(ItemID.ChainGun);
            r.AddIngredient(ItemID.Megashark);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3; //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(Main.rand.Next(1, 4))); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.Next(10) == 0)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(Main.rand.Next(3, 7))); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.RocketSnowmanIII, damage * 3, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}
