using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles
{
    public class MalachiteSwordProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Beam");
        }
        public override void SetDefaults()
        {
            projectile.damage = 274;
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.knockBack = 4f;
            projectile.melee = true;
            projectile.scale = 1.2f;
            projectile.tileCollide = true;
            projectile.timeLeft = 200;
            projectile.extraUpdates = 3;
            projectile.ignoreWater = true;
            projectile.light = 1.275f;



        }
        //For all of the NPC slots in Main.npc
        //Note, you can replace NPC with other entities such as Projectiles and Players
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            int num30 = Dust.NewDust(projectile.position, projectile.width + 10, projectile.height + 10, DustID.RainbowMk2, 0f, 0f, 255, new Color(0, 255, 0), 1.35f);
            Dust dust3 = Main.dust[num30];
            dust3.velocity *= 0.1f;
            Main.dust[num30].noGravity = true;
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                //If the npc is hostile
                if (!target.friendly && target.type != 488)
                {
                    //Get the shoot trajectory from the projectile and target
                    float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                    float shootToY = target.position.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    //If the distance between the live targeted npc and the projectile is less than 480 pixels
                    if (distance < 480f && !target.friendly && target.active && Collision.CanHit(new Vector2(projectile.position.X + (float)(projectile.width / 2), projectile.position.Y + (float)(projectile.height / 2)), 1, 1, Main.npc[i].position, Main.npc[i].width, Main.npc[i].height))
                    {
                        //Divide the factor, 3f, which is the desired velocity
                        distance = 3f / distance;

                        //Multiply the distance by a multiplier if you wish the projectile to have go faster
                        shootToX *= distance * 5;
                        shootToY *= distance * 5;

                        //Set the velocities to the shoot values
                        projectile.velocity.X = shootToX / 3;
                        projectile.velocity.Y = shootToY / 3;
                    }
                }
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Random rand = new Random();
            Vector2 projPos = new Vector2(projectile.position.X, projectile.position.Y);
            Vector2 targetPos = new Vector2(target.position.X * rand.Next(-4, 4), target.position.Y * rand.Next(-4, 4));
            if (crit)
            {
                target.AddBuff(BuffID.Ichor, damage * 10);
            }
            Projectile.NewProjectile(targetPos, new Vector2(projectile.velocity.X / 100, projectile.velocity.Y / 100), mod.ProjectileType("MalachiteStinger"), damage / 4, knockback, projectile.owner);


            int dust = Dust.NewDust(projectile.position, projectile.width + 10, projectile.height + 10, DustID.RainbowMk2, 0f, 0f, 255, new Color(0, 255, 0), 2f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;
            Main.dust[dust].scale = 2f;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Vector2 projPos = new Vector2(projectile.position.X, projectile.position.Y);
            int dust = Dust.NewDust(projectile.position, projectile.width + 10, projectile.height + 10, DustID.RainbowMk2, 0f, 0f, 255, new Color(0, 255, 0), 2f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;
            Main.dust[dust].scale = 2f;

            return base.OnTileCollide(oldVelocity);
        }

    }
}
