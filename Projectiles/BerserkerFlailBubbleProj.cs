using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;
using Microsoft.Xna.Framework.Graphics;

namespace SwagModv2.Projectiles
{
    public class BerserkerFlailBubbleProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Berserker Bubble");
        }
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 70;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.alpha = 255;
            projectile.timeLeft = 90;
            projectile.melee = true;
            projectile.noEnchantments = true;
			projectile.damage = 652;
            aiType = ProjectileID.FlaironBubble;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 25);
        }
        //Note, you can use this with an NPC to shoot at a Player also
        //For every npc slot in Main.npc
        public override void AI()
        {
            for (int i = 0; i < 200; i++)
            {
                //Enemy NPC variable being set
                NPC target = Main.npc[i];

                //Getting the shooting trajectory
                float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                float shootToY = target.position.Y - projectile.Center.Y;
                float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                //If the distance between the projectile and the live target is active
                if (distance < 480f && !target.friendly && target.active 
                    && Collision.CanHit(new Vector2(projectile.position.X + (float)(projectile.width / 2), projectile.position.Y + (float)(projectile.height / 2)), 1, 1, target.position, target.width, target.height)
                    && target.CanBeChasedBy(mod.ProjectileType("BerserkerFlailBubbleProj"), false))
                {
                    if (projectile.ai[0] > 20f) //Assuming you are already incrementing this in AI outside of for loop
                    {
                        projectile.velocity = new Vector2(0, 0);
                        //Dividing the factor of 3f which is the desired velocity by distance
                        distance = 3f / distance;

                        //Multiplying the shoot trajectory with distance times a multiplier if you so choose to
                        shootToX *= distance * 5;
                        shootToY *= distance * 5;

                        //Shoot projectile and set ai back to 0
                        Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, mod.ProjectileType("BerserkerSharkron"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
                        Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, SoundID.Waterfall); //Bullet noise
                        projectile.ai[0] = 0f;
                    }
                }
            }
            projectile.ai[0] += 1f;
        }
        public override bool PreKill(int timeLeft)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 54);
            return base.PreKill(timeLeft);
        }
    }
}
