using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Projectiles.MagmaBolt
{
    public class MagmaBoltProj : ModProjectile
    {
        private int totalHit;
        private Vector2 velocity = new Vector2(0, 0);
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magma Bolt");
        }
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.alpha = 255;
            projectile.timeLeft /= 2;
            projectile.penetrate = 10;
            projectile.magic = true;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10); // Plays a hit sound when the projectile collides.
            this.totalHit++; // Increases the amount of collides, to keep track on how many collides the projectile performes.
            this.velocity = oldVelocity; // Sets "velocity" (which is a variable create above), to the oldVelocity (when the projectile collided).
            return false;
        }
        public override void AI()
        {
            if (this.totalHit == 5) // Check for 5 collides then kill the projectile.
            {
                projectile.Kill();
            }
            // Waterbolt AI
            if (projectile.velocity.Y != this.velocity.Y && this.velocity.Y != 0) // " && this.velocity.Y != 0" added to check if the projectile actually collided.
            {
                projectile.velocity.Y = -this.velocity.Y; 
            }
		    if (projectile.velocity.X != this.velocity.X && this.velocity.X != 0) // " && this.velocity.X != 0" added to check if the projectile actually collided.
            {
                projectile.velocity.X = -this.velocity.X; 
            }
            // Custom Dust
            int num3;
            for (int num93 = 0; num93 < 5; num93 = num3 + 1)
            {
                float num94 = projectile.velocity.X / 3f * (float)num93;
                float num95 = projectile.velocity.Y / 3f * (float)num93;
                int num96 = 4;
                int num97 = Dust.NewDust(new Vector2(projectile.position.X + (float)num96, projectile.position.Y + (float)num96), projectile.width - num96 * 2 - 4, projectile.height - num96 * 2 - 8, mod.DustType("MagmaBoltDust"), 0f, 0f, 100, new Color(100, 0, 0, 50), 1.4f);
                Main.dust[num97].noGravity = true;
                Dust dust3 = Main.dust[num97];
                dust3.velocity *= 0.1f;
                dust3 = Main.dust[num97];
                dust3.velocity += projectile.velocity * 0.1f;
                Dust dust6 = Main.dust[num97];
                dust6.position.X = dust6.position.X - num94;
                Dust dust7 = Main.dust[num97];
                dust7.position.Y = dust7.position.Y - num95;
                num3 = num93;
            }
            if (Main.rand.Next(5) == 0)
            {
                int num98 = 4;
                int num99 = Dust.NewDust(new Vector2(projectile.position.X + (float)num98, projectile.position.Y + (float)num98), projectile.width - num98 * 2 - 4, projectile.height - num98 * 2 - 8, mod.DustType("MagmaBoltDust"), 0f, 0f, 100, default(Color), 0.8f);
                Dust dust3 = Main.dust[num99];
                dust3.velocity *= 0.25f;
                dust3 = Main.dust[num99];
                dust3.velocity += projectile.velocity * 0.5f;
            }
        }
    }
}
