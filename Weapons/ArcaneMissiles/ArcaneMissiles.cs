using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissiles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 1]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 10;
            item.useTime = 20;
            item.useAnimation = 80;
            item.useStyle = 5;
            item.knockBack = 4.0f;
            item.magic = true;
            item.shoot = mod.ProjectileType("ArcaneMissilesProj");
            item.shootSpeed = 3.2f;
            item.damage = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item43;
            item.mana = 20;
            item.value = Item.buyPrice(0, 0, 2, 0);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y + 30, speedX, speedY, type, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y + 10, speedX, speedY, type, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y - 30, speedX, speedY, type, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y - 10, speedX, speedY, type, damage, knockBack, player.whoAmI);
            return false;
        }
    }
}
