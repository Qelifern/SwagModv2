using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles.FrostBolt
{
    public class FrostBoltProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 1]");
        }
        public override void SetDefaults()
        {
            projectile.damage = 8;
            projectile.width = 14;
            projectile.height = 14;
            projectile.friendly = true;
            projectile.knockBack = 4f;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 500;
            projectile.extraUpdates = 3;
            projectile.ignoreWater = true;



        }
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 4f)
            {
                int num3;
                for (int num93 = 0; num93 < 5; num93 = num3 + 1)
                {
                    float num94 = projectile.velocity.X / 3f * (float)num93;
                    float num95 = projectile.velocity.Y / 3f * (float)num93;
                    int num96 = 4;
                    int num97 = Dust.NewDust(new Vector2(projectile.position.X + (float)num96, projectile.position.Y + (float)num96), projectile.width - num96 * 2, projectile.height - num96 * 2, 172, 0f, 0f, 100, new Color(250, 250, 250, 150), 1.6f);
                    Main.dust[num97].noGravity = true;
                    Dust dust3 = Main.dust[num97];
                    dust3.velocity *= 0.1f;
                    dust3 = Main.dust[num97];
                    dust3.velocity += projectile.velocity * 0.05f;
                    Dust dust6 = Main.dust[num97];
                    dust6.position.X = dust6.position.X - num94;
                    Dust dust7 = Main.dust[num97];
                    dust7.position.Y = dust7.position.Y - num95;
                    num3 = num93;
                }
                if (Main.rand.Next(5) == 0)
                {
                    int num98 = 4;
                    int num99 = Dust.NewDust(new Vector2(projectile.position.X + (float)num98, projectile.position.Y + (float)num98), projectile.width - num98 * 2, projectile.height - num98 * 2, 172, 0f, 0f, 100, new Color(150, 150, 150, 150), 1f);
                    Dust dust3 = Main.dust[num99];
                    dust3.velocity *= 0.25f;
                    dust3 = Main.dust[num99];
                    dust3.velocity += projectile.velocity * 0.01f;
                }
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
					//Pythagoram Theorum
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

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (Main.rand.Next(9) == 0)
            {
                player.AddBuff(mod.BuffType("Shatter"), 400);
            }
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (Main.rand.Next(9) == 0)
            {
                player.AddBuff(mod.BuffType("Shatter"), 400);
            }
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (Main.rand.Next(9) == 0)
            {
                player.AddBuff(mod.BuffType("Shatter"), 400);
            }
        }
    }
}
