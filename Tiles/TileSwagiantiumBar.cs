using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileSwagiantiumBar : ModTile
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
            dustType = 127;
            drop = mod.ItemType("SwagiantiumBar");
            Color color = new Color(156, 42, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Swagiantium Bar");
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
