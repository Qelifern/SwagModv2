using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileCupriteAnvil : ModTile
    {

        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileID.Sets.Ore[Type] = true;
            disableSmartCursor = true;
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.Anvils };
            dustType = 125;
            Color color = new Color(132, 43, 46);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Cuprite Anvil");
            AddMapEntry(color, name);
            minPick = 245;
            mineResist = 1f;
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
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("CupriteAnvil"));
        }

    }
}
