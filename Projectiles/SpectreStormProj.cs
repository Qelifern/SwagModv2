using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles
{
    public class SpectreStormProj : SoulEdgeProj
    {

        public override string Texture { get { return "Terraria/Projectile_" + 297; } }

        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.tileCollide = true;
            projectile.magic = true;
            projectile.melee = false;
            projectile.knockBack = 2.5f;
            projectile.timeLeft = 350;
        }
    }
}
