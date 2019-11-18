using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.ArcaneMissiles
{
    public class ArcaneMissilesRank6 : ArcaneMissiles
    {
        public override string Texture { get { return "SwagModv2/Weapons/ArcaneMissiles/ArcaneMissiles"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Missiles [Rank 6]");
            Tooltip.SetDefault("Hurls missiles of arcane at your target.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("ArcaneMissilesProjRank6");
            item.damage = 44;
            item.mana = 54;
            item.value = Item.buyPrice(0, 15, 0, 0);
        }
    }
}
