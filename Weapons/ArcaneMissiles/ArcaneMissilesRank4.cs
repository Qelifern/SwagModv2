using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissilesRank4 : ArcaneMissiles
    {
        public override string Texture { get { return "SwagModv2/Weapons/ArcaneMissiles/ArcaneMissiles"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 4]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ArcaneMissilesProjRank4");
            item.damage = 30;
            item.mana = 38;
            item.value = Item.buyPrice(0, 7, 50, 0);
        }
    }
}
