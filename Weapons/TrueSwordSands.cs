using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons
{
    public class TrueSwordSands : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Sword of the Desert Scourge");
            Tooltip.SetDefault("Has a chance to fling enemies up in the air");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 19, 25, 3);
            item.rare = 6;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 4.4f;
            item.melee = true;
            item.damage = 76;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("TrueSwordSandsProj");
            item.shootSpeed = 4.4f;
            item.crit += 5;
            item.scale = 1.2f;
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
                if (target.type != NPCID.TargetDummy)
                {
                    target.AddBuff(mod.BuffType("SandFling"), 150);
                    target.velocity.Y -= 15f;
                }
            }
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwordSands"), 1);
            r.AddIngredient(ItemID.BrokenHeroSword, 1);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(mod.ItemType("TrueSwordSands"));
            r.AddRecipe();

            ModRecipe r2 = new ModRecipe(mod);
            r2.AddIngredient(mod.ItemType("TrueSwordSands"), 1);
            r2.AddIngredient(ItemID.TrueExcalibur, 1);
            r2.AddTile(TileID.MythrilAnvil);
            r2.SetResult(ItemID.TerraBlade);
            r2.AddRecipe();

            ModRecipe r3 = new ModRecipe(mod);
            r3.AddIngredient(mod.ItemType("TrueSwordSands"), 1);
            r3.AddIngredient(ItemID.TrueNightsEdge, 1);
            r3.AddTile(TileID.MythrilAnvil);
            r3.SetResult(ItemID.TerraBlade);
            r3.AddRecipe();
        }
    }
}
