using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwagModv2.Tiles
{
    public class TileCupriteOre : ModTile
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
            dustType = 125;
            drop = mod.ItemType("Cuprite");
            Color color = new Color(132, 43, 46);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Cuprite");
            AddMapEntry(color, name);
            minPick = 245;
            mineResist = 10f;

        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }

    }
}
