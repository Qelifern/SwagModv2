using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissilesRank5 : ArcaneMissiles
    {
        public override string Texture { get { return "SwagModv2/Weapons/ArcaneMissiles/ArcaneMissiles"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 5]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ArcaneMissilesProjRank5");
            item.damage = 38;
            item.mana = 45;
            item.value = Item.buyPrice(0, 10, 0, 0);
        }
    }
}
