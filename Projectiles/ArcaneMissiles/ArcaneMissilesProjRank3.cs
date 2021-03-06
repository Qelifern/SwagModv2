﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles.ArcaneMissiles
{
    public class ArcaneMissilesProjRank3 : ArcaneMissilesProj
    {
        public override string Texture { get { return "SwagModv2/Projectiles/ArcaneMissiles/ArcaneMissilesProj"; } }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 3]");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.damage = 23;



        }
    }
}
