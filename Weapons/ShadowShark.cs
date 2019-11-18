using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.SwagPlayer;

namespace SwagModv2.Weapons
{
    public class ShadowShark : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadowshark");
            Tooltip.SetDefault("100% chance to not consume ammo\nTurns any bullet into a shadowshark bullet, this bullet either homes in on enemies or bounces on impact with any surface\nRight click to switch modes");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 12;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 48, 0, 0);
            item.rare = 11;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.crit += 50;
            item.knockBack = 4.0f;
            item.ranged = true;
            item.shoot = mod.ProjectileType("ShadowSharkBullet");
            item.shootSpeed = 25f;
            item.damage = 245;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useTime = 15;
                item.useAnimation = 15;
                item.UseSound = SoundID.Item4;
                if (SwagPlayer.SwagPlayer.shadowChase)
                {
                    SwagPlayer.SwagPlayer.shadowChase = false;
                    Main.NewText("Shadowshark will now fire bouncing Shadowshark Bullets", 25, 0, 41);
                }
                else
                {
                    SwagPlayer.SwagPlayer.shadowChase = true;
                    Main.NewText("Shadowshark will now fire homing Shadowshark Bullets", 25, 0, 41);
                }
            }
            else
            {
                item.useTime = 2;
                item.useAnimation = 2;
                item.UseSound = SoundID.Item11;
            }
            return base.CanUseItem(player);
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 1);
        }

        public override bool ConsumeAmmo(Player player)
        {
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.SDMG);
            r.AddIngredient(ItemID.Megashark);
            r.AddIngredient(ItemID.OnyxBlaster);
            r.AddIngredient(ItemID.FragmentNebula, 5);
            r.AddIngredient(ItemID.FragmentVortex, 5);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6; //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(Main.rand.Next(1, 4))); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("ShadowSharkBullet"), damage, knockBack, player.whoAmI);
            }
            if (Main.rand.Next(10) <= 3)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(Main.rand.Next(3, 7))); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BlackBolt, damage * 3, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}
