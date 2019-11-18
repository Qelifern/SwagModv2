using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwagModv2.Tiles
{
    public class TileSwagiantiumOre : ModTile
    {

        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 800;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 750;
            TileID.Sets.Ore[Type] = true;
            soundType = 21;
            soundStyle = 1;
            dustType = 127;
            drop = mod.ItemType("Swagiantium");
            Color color = new Color(156, 42, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Swagiantium");
            AddMapEntry(color, name);
            minPick = 255;
            mineResist = 12f;
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }

    }
}
