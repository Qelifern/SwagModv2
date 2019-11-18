using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles
{
    public class TrueSwordSandsProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sandstorm!");
        }
        public override void SetDefaults()
        {
            projectile.damage = 79;
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.knockBack = 4.4f;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
            projectile.extraUpdates = 3;
            projectile.ignoreWater = true;
            projectile.penetrate = 1;



        }
        //For all of the NPC slots in Main.npc
        //Note, you can replace NPC with other entities such as Projectiles and Players
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            int num30 = Dust.NewDust(new Vector2(projectile.Center.X , projectile.Center.Y), projectile.width + Main.rand.Next(-5, 5), projectile.height + Main.rand.Next(-5, 5), DustID.AmberBolt, 0f, 0f, 255, new Color(145, 115, 45), 1.3f);
            Dust dust3 = Main.dust[num30];
            dust3.velocity *= 0.1f;
            Main.dust[num30].noGravity = true;
        }
    }
}
