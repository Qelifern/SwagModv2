using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;
using Microsoft.Xna.Framework.Graphics;

namespace SwagModv2.Projectiles
{
    public class BerserkerSharkron : ModProjectile
    {
        public override string Texture { get { return "Terraria/Projectile_" + ProjectileID.MiniSharkron; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Berserker Sharkron");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.MiniSharkron);
            projectile.damage = 152;
            projectile.aiStyle = 1;
            projectile.melee = true;
            projectile.minion = false;
            projectile.minionSlots = 0;
            aiType = ProjectileID.MiniSharkron;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 100);
        }
    }
}
