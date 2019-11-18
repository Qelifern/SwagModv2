using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class SwordSands : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword of the Desert Scourge");
            Tooltip.SetDefault("Has a chance to fling enemies up in the air.");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 40, 25, 15);
            item.rare = 4;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4.0f;
            item.melee = true;
            item.damage = 24;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(2) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sandstorm);
            }
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.Next(10) == 0)
            {
                target.AddBuff(mod.BuffType("SandFling"), 150);
                target.velocity.Y -= 15f;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.SandBlock, 20);
            r.AddIngredient(ItemID.AntlionMandible, 2);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
