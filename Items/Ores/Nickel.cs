using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items.Ores
{
    public class Nickel : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Ore");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.width = 16;
            item.height = 16;
            item.rare = 2;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("TileNickelOre");
        }

    }
}
