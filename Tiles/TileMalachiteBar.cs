using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileMalachiteBar : ModTile
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
            dustType = 128;
            drop = mod.ItemType("MalachiteBar");
            Color color = new Color(0, 201, 25);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Malachite Bar");
            AddMapEntry(color, name);
            minPick = 225;
            mineResist = 8f;
        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }

    }
}
