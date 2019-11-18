using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles.ArcaneMissiles
{
    public class ArcaneMissilesProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 1]");
        }
        public override void SetDefaults()
        {
            projectile.damage = 5;
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
        //For all of the NPC slots in Main.npc
        //Note, you can replace NPC with other entities such as Projectiles and Players
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 4f)
            {
                int num30 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.CrystalPulse, 0f, 0f, 255, new Color(63, 0, 42), 1f);
                Dust dust3 = Main.dust[num30];
                dust3.velocity *= 0.1f;
                Main.dust[num30].noGravity = true;
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
                    num489 *= num491;
                    num490 *= num491;
                    projectile.velocity.X = (projectile.velocity.X * 20f + num489) / 21f;
                    projectile.velocity.Y = (projectile.velocity.Y * 20f + num490) / 21f;
                    return;
                }
            }
        }
    }
}
