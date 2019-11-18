using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileSwagiantiumForge : ModTile
    {

        public override void SetDefaults()
        {
            Main.tileSolid[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
            disableSmartCursor = true;
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.Furnaces };
            dustType = 127;
            Color color = new Color(156, 42, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Swagiantium Forge");
            AddMapEntry(color, name);
            minPick = 255;
            mineResist = 1f;
            TileID.Sets.Ore[Type] = true;
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("SwagiantiumForge"));
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.2f;
            g = 3f;
            b = 0.2f;
        }

    }
}
