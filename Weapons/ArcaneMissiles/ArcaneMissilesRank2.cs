using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissilesRank2 : ArcaneMissiles
    {
        public override string Texture { get { return "SwagModv2/Weapons/ArcaneMissiles/ArcaneMissiles"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 2]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ArcaneMissilesProjRank2");
            item.damage = 15;
            item.mana = 26;
            item.value = Item.buyPrice(0, 1, 0, 0);
        }
    }
}
