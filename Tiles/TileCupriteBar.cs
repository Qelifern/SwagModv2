using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileCupriteBar : ModTile
    {

        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.addTile(Type);
            TileID.Sets.Ore[Type] = true;
            soundType = 21;
            soundStyle = 1;
            dustType = 125;
            drop = mod.ItemType("CupriteBar");
            Color color = new Color(132, 43, 46);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Cuprite Bar");
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
