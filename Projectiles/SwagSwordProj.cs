using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;
using SwagModv2.Items;

namespace SwagModv2.Projectiles
{
    public class SwagSwordProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Beam");
        }
        public override void SetDefaults()
        {
            projectile.damage = 584;
            projectile.width = 40;
            projectile.height = 40;
            projectile.friendly = true;
            projectile.knockBack = 4f;
            projectile.melee = true;
            projectile.scale = 1f;
            projectile.tileCollide = false;
            projectile.penetrate = 50;
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
                    if (distance < 1000f && !target.friendly && target.active)
                    {
                        //Divide the factor, 3f, which is the desired velocity
                        distance = 3f / distance;

                        //Multiply the distance by a multiplier if you wish the projectile to have go faster
                        shootToX *= distance * 3;
                        shootToY *= distance * 3;

                        //Set the velocities to the shoot values
                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
                    }
                }
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Vector2 projPos = new Vector2(projectile.position.X, projectile.position.Y);
            Vector2 targetPos = new Vector2(target.position.X, target.position.Y);
            if (crit)
            {
                projectile.vampireHeal(damage / 5, projPos);
            }
            target.AddBuff(BuffID.Poisoned, damage * 2);
            int dust = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust2 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust3 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust4 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust5 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust6 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust7 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust8 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust9 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust10 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust11 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust12 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust13 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust14 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust15 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            int dust16 = Dust.NewDust(projPos, projectile.width, projectile.height, DustID.Electric, 0f, 0f, 255, new Color(0, 87, 172), 4f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;
            Main.dust[dust].scale = 2f;
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].noLight = false;
            Main.dust[dust2].scale = 2f;
            Main.dust[dust3].noGravity = true;
            Main.dust[dust3].noLight = false;
            Main.dust[dust3].scale = 2f;
            Main.dust[dust4].noGravity = true;
            Main.dust[dust4].noLight = false;
            Main.dust[dust4].scale = 2f;
            Main.dust[dust5].noGravity = true;
            Main.dust[dust5].noLight = false;
            Main.dust[dust5].scale = 2f;
            Main.dust[dust6].noGravity = true;
            Main.dust[dust6].noLight = false;
            Main.dust[dust6].scale = 2f;
            Main.dust[dust7].noGravity = true;
            Main.dust[dust7].noLight = false;
            Main.dust[dust7].scale = 2f;
            Main.dust[dust8].noGravity = true;
            Main.dust[dust8].noLight = false;
            Main.dust[dust8].scale = 2f;
            Main.dust[dust9].noGravity = true;
            Main.dust[dust9].noLight = false;
            Main.dust[dust9].scale = 2f;
            Main.dust[dust10].noGravity = true;
            Main.dust[dust10].noLight = false;
            Main.dust[dust10].scale = 2f;
            Main.dust[dust11].noGravity = true;
            Main.dust[dust11].noLight = false;
            Main.dust[dust11].scale = 2f;
            Main.dust[dust12].noGravity = true;
            Main.dust[dust12].noLight = false;
            Main.dust[dust12].scale = 2f;
            Main.dust[dust13].noGravity = true;
            Main.dust[dust13].noLight = false;
            Main.dust[dust13].scale = 2f;
            Main.dust[dust14].noGravity = true;
            Main.dust[dust14].noLight = false;
            Main.dust[dust14].scale = 2f;
            Main.dust[dust15].noGravity = true;
            Main.dust[dust15].noLight = false;
            Main.dust[dust15].scale = 2f;
            Main.dust[dust16].noGravity = true;
            Main.dust[dust16].noLight = false;
            Main.dust[dust16].scale = 2f;
        }

    }
}
