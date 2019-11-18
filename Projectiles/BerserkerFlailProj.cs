using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;
using Microsoft.Xna.Framework.Graphics;

namespace SwagModv2.Projectiles
{
    public class BerserkerFlailProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Berserker Flail");
        }
        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.alpha = 255;
            projectile.melee = true;


        }
        // Now this is where the chain magic happens. You don't have to try to figure this whole thing out.
        // Just make sure that you edit the first line (which starts with 'Texture2D texture') correctly.
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            // So set the correct path here to load the chain texture. 'YourModName' is of course the name of your mod.
            // Then into the Projectiles folder and take the texture that is called 'CustomFlailBall_Chain'.
            Texture2D texture = ModContent.GetTexture("SwagModv2/Projectiles/BerserkerFlailChain");

            Vector2 position = projectile.Center;
            Vector2 mountedCenter = Main.player[projectile.owner].MountedCenter;
            Microsoft.Xna.Framework.Rectangle? sourceRectangle = new Microsoft.Xna.Framework.Rectangle?();
            Vector2 origin = new Vector2((float)texture.Width * 0.5f, (float)texture.Height * 0.5f);
            float num1 = (float)texture.Height;
            Vector2 vector2_4 = mountedCenter - position;
            float rotation = (float)Math.Atan2((double)vector2_4.Y, (double)vector2_4.X) - 1.57f;
            bool flag = true;
            if (float.IsNaN(position.X) && float.IsNaN(position.Y))
                flag = false;
            if (float.IsNaN(vector2_4.X) && float.IsNaN(vector2_4.Y))
                flag = false;
            while (flag)
            {
                if ((double)vector2_4.Length() < (double)num1 + 1.0)
                {
                    flag = false;
                }
                else
                {
                    Vector2 vector2_1 = vector2_4;
                    vector2_1.Normalize();
                    position += vector2_1 * num1;
                    vector2_4 = mountedCenter - position;
                    Microsoft.Xna.Framework.Color color2 = Lighting.GetColor((int)position.X / 16, (int)((double)position.Y / 16.0));
                    color2 = projectile.GetAlpha(color2);
                    Main.spriteBatch.Draw(texture, position - Main.screenPosition, sourceRectangle, color2, rotation, origin, 1.35f, SpriteEffects.None, 0.0f);
                }
            }

            return true;
        }
        public override void AI()
        {
                Vector2 vector62 = Main.player[projectile.owner].Center - projectile.Center;
                projectile.rotation = vector62.ToRotation() - 1.57f;
                if (Main.player[projectile.owner].dead)
                {
                    projectile.Kill();
                    return;
                }
                Main.player[projectile.owner].itemAnimation = 10;
                Main.player[projectile.owner].itemTime = 10;
                float x = vector62.X;
                if (vector62.X < 0f)
                {
                    Main.player[projectile.owner].ChangeDir(1);
                    projectile.direction = 1;
                }
                else
                {
                    Main.player[projectile.owner].ChangeDir(-1);
                    projectile.direction = -1;
                }
                Main.player[projectile.owner].itemRotation = (vector62 * -1f * (float)projectile.direction).ToRotation();
                projectile.spriteDirection = ((vector62.X > 0f) ? -1 : 1);
                if (projectile.ai[0] == 0f && vector62.Length() > 400f)
                {
                    projectile.ai[0] = 1f;
                }
                if (projectile.ai[0] == 1f || projectile.ai[0] == 2f)
                {
                    float num702 = vector62.Length();
                    if (num702 > 1500f)
                    {
                    projectile.Kill();
                        return;
                    }
                    if (num702 > 600f)
                    {
                    projectile.ai[0] = 2f;
                    }
                    projectile.tileCollide = false;
                    float num703 = 20f;
                    if (projectile.ai[0] == 2f)
                    {
                        num703 = 40f;
                    }
                    projectile.velocity = Vector2.Normalize(vector62) * num703;
                    if (vector62.Length() < num703)
                    {
                    projectile.Kill();
                        return;
                    }
                }
                projectile.ai[1] += 1f;
                if (projectile.ai[1] > 5f)
                {
                    projectile.alpha = 0;
                }
                if ((int)projectile.ai[1] % 4 == 0 && projectile.owner == Main.myPlayer)
                {
                    Vector2 vector63 = vector62 * -1f;
                    vector63.Normalize();
                    vector63 *= (float)Main.rand.Next(45, 65) * 0.1f;
                    vector63 = vector63.RotatedBy((Main.rand.NextDouble() - 0.5) * 1.5707963705062866, default(Vector2));
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vector63.X, vector63.Y, mod.ProjectileType("BerserkerFlailBubbleProj"), projectile.damage, projectile.knockBack, projectile.owner, -10f, 0f);
                    return;
                }
        }
    }
}
