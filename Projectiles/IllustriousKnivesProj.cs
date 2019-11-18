using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles
{
    public class IllustriousKnivesProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Illustrious Knife");
        }
        public override void SetDefaults()
        {
            projectile.width = 6;
            projectile.height = 6;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.melee = true;
            projectile.light = 0.2f;
            projectile.ignoreWater = true;
            projectile.extraUpdates = 0;
        }
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] < 30f)
            {
                projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            }
            if (projectile.localAI[0] > 20f)
            {
                float num477 = projectile.Center.X;
                float num478 = projectile.Center.Y;
                float num479 = 400f;
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
                    float num488 = 6f;
                    num488 = 6f;
                    Vector2 vector38 = new Vector2(projectile.position.X + (float)projectile.width * 0.5f, projectile.position.Y + (float)projectile.height * 0.5f);
                    float num489 = num477 - vector38.X;
                    float num490 = num478 - vector38.Y;
                    float num491 = (float)Math.Sqrt((double)(num489 * num489 + num490 * num490));
                    num491 = num488 / num491;
                    num489 *= num491 * 21;
                    num490 *= num491 * 21;
                    projectile.velocity.X = (projectile.velocity.X * 20f + num489) / 21f;
                    projectile.velocity.Y = (projectile.velocity.Y * 20f + num490) / 21f;
                    return;
                }
            }
            int num4;
            for (int num93 = 0; num93 < 5; num93 = num4 + 1)
            {
                float num94 = projectile.velocity.X / 3f * (float)num93;
                float num95 = projectile.velocity.Y / 3f * (float)num93;
                int num96 = 4;
                int num97 = Dust.NewDust(new Vector2(projectile.position.X + (float)num96, projectile.position.Y + (float)num96), projectile.width - num96 * 2 - 4, projectile.height - num96 * 2 - 8, 128, 0f, 0f, 100, new Color(100, 0, 0, 50), 0.8f);
                Main.dust[num97].noGravity = true;
                Dust dust3 = Main.dust[num97];
                dust3.velocity *= 0.1f;
                dust3 = Main.dust[num97];
                dust3.velocity += projectile.velocity * 0.1f;
                Dust dust6 = Main.dust[num97];
                dust6.position.X = dust6.position.X - num94;
                Dust dust7 = Main.dust[num97];
                dust7.position.Y = dust7.position.Y - num95;
                num4 = num93;
            }
            if (Main.rand.Next(5) == 0)
            {
                int num98 = 4;
                int num99 = Dust.NewDust(new Vector2(projectile.position.X + (float)num98, projectile.position.Y + (float)num98), projectile.width - num98 * 2 - 4, projectile.height - num98 * 2 - 8, 128, 0f, 0f, 100, default(Color), 0.4f);
                Dust dust3 = Main.dust[num99];
                dust3.velocity *= 0.25f;
                dust3 = Main.dust[num99];
                dust3.velocity += projectile.velocity * 0.5f;
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (damage > 0 && target.lifeMax > 5 && !Main.player[projectile.owner].moonLeech)
            {
                projectile.vampireHeal(damage, new Vector2(target.Center.X, target.Center.Y));
            }
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 25);
        }
    }
}
