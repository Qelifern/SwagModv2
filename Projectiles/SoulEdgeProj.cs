using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles
{
    public class SoulEdgeProj : ModProjectile
    {

        public override string Texture { get { return "Terraria/Projectile_" + 297; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lost Soul");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(297);
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.knockBack = 6.2f;
            projectile.melee = true;
            aiType = 297;
            projectile.scale = 0.5f;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 25);
        }
    }
}
