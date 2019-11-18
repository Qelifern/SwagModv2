using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissilesRank7 : ArcaneMissiles
    {
        public override string Texture { get { return "SwagModv2/Weapons/ArcaneMissiles/ArcaneMissiles"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 7]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ArcaneMissilesProjRank7");
            item.damage = 50;
            item.mana = 67;
            item.useTime = 15;
            item.useAnimation = 60;
            item.value = Item.buyPrice(0, 20, 0, 0);
        }
    }
}
