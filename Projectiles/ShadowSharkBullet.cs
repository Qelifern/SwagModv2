using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.SwagPlayer;

namespace SwagModv2.Projectiles
{
    public class ShadowSharkBullet : ModProjectile
    {
        private int totalHit;
        private Vector2 velocity = new Vector2(0, 0);
        private float rotation = 0f;
        private bool chase = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadowshark Bullet");
        }
        public override void SetDefaults()
        {
            projectile.width = 11;
            projectile.height = 3;
            projectile.friendly = true;
            projectile.timeLeft /= 2;
            projectile.penetrate = 500;
            projectile.ranged = true;
            projectile.light = 0.250f;
            this.chase = SwagPlayer.SwagPlayer.shadowChase;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10); // Plays a hit sound when the projectile collides.
            if (this.chase)
            {
                projectile.Kill();
                return base.OnTileCollide(oldVelocity);
            }
            else
            {
                this.totalHit++; // Increases the amount of collides, to keep track on how many collides the projectile performes.
                this.velocity = oldVelocity; // Sets "velocity" (which is a variable create above), to the oldVelocity (when the projectile collided).
                this.rotation = (float)Math.Atan2((double)oldVelocity.Y, (double)oldVelocity.X) + 1.57f;
            }
            return false;
        }
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (this.chase)
            {
                projectile.penetrate = 1;
                if (projectile.localAI[0] > 4f)
                {
                    float num477 = projectile.Center.X;
                    float num478 = projectile.Center.Y;
                    float num479 = 500f;
                    bool flag17 = false;
                    int num3;
                    for (int num480 = 0; num480 < 200; num480 = num3 + 1)
                    {
                        if (Main.npc[num480].CanBeChasedBy(projectile, false) && Collision.CanHit(projectile.Center, 1, 1, Main.npc[num480].Center, 1, 1))
                        {
                            float num481 = Main.npc[num480].position.X + (float)(Main.npc[num480].width / 2);
                            float num482 = Main.npc[num480].position.Y + (float)(Main.npc[num480].height / 2);
                            float num483 = Math.Abs(projectile.position.X + (float)(projectile.width / 2) - num481) + Math.Abs(projectile.position.Y + (float)(projectile.height / 2) - num482);
                            if (num483 < num479)
                            {
                                num479 = num483;
                                num477 = num481;
                                num478 = num482;
                                flag17 = true;
                            }
                        }
                        num3 = num480;
                    }
                    if (flag17)
                    {
                        float num488 = 192f + Main.rand.NextFloat(6);
                        num488 = 192f + Main.rand.NextFloat(6);
                        Vector2 vector38 = new Vector2(projectile.position.X + (float)projectile.width * 0.5f, projectile.position.Y + (float)projectile.height * 0.5f);
                        float num489 = num477 - vector38.X;
                        float num490 = num478 - vector38.Y;
                        float num491 = (float)Math.Sqrt((double)(num489 * num489 + num490 * num490));
                        num491 = num488 / num491;
                        num489 *= num491;
                        num490 *= num491;
                        projectile.velocity.X = (projectile.velocity.X * 20f + num489) / 21f;
                        projectile.velocity.Y = (projectile.velocity.Y * 20f + num490) / 21f;
                        return;
                    }
                }
            }
            else
            {
                projectile.penetrate = 500;
                if (this.totalHit == 3) // Check for 5 collides then kill the projectile.
                {
                    projectile.Kill();
                }
                // Waterbolt AI
                if (projectile.velocity.Y != this.velocity.Y && this.velocity.Y != 0) // " && this.velocity.Y != 0" added to check if the projectile actually collided.
                {
                    projectile.velocity.Y = -this.velocity.Y;
                    projectile.rotation = -this.rotation;
                }
                if (projectile.velocity.X != this.velocity.X && this.velocity.X != 0) // " && this.velocity.X != 0" added to check if the projectile actually collided.
                {
                    projectile.velocity.X = -this.velocity.X;
                    projectile.rotation = -this.rotation;
                }
            }
            if (this.chase != SwagPlayer.SwagPlayer.shadowChase)
            {
                this.chase = SwagPlayer.SwagPlayer.shadowChase;
            }
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 10);
        }
    }
}
