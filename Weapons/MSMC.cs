using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class MSMC : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MSMC");
            Tooltip.SetDefault("20% chance to not consume ammo");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 18;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 89, 0);
            item.rare = 6;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.crit += 5;
            item.knockBack = 2.0f;
            item.ranged = true;
            item.shoot = 10;
            item.shootSpeed = 14f;
            item.damage = 11;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-18, 4);
        }

        public override bool ConsumeAmmo(Player player)
        {
            int shit = Main.rand.Next(100);
            if (shit < 20)
            {
                return false;
            }
            return base.ConsumeAmmo(player);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(Main.rand.Next(1, 2))); // This defines the projectiles random spread . 30 degree spread.
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            return false;
        }
    }
}
