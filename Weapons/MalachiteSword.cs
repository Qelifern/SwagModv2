using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class MalachiteSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Edge");
            Tooltip.SetDefault("Fires a projectile that chases after your enemies.\nThe projectile has a 30% chance to spawn a rainbow crystal on enemy hits.");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 88, 25, 15);
            item.rare = 9;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 1;
            item.crit += 10;
            item.knockBack = 4.0f;
            item.melee = true;
            item.shoot = mod.ProjectileType("MalachiteSwordProj");
            item.shootSpeed = 5;
            item.damage = 274;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.scale = 1.6f;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (crit)
            {
                target.AddBuff(BuffID.Ichor, 18000);
            }
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(5) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.ToxicBubble);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("MalachiteBar"), 18);
            r.AddIngredient(ItemID.BrokenHeroSword);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
