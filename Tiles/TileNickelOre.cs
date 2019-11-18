using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SwagModv2.Tiles
{
    public class TileNickelOre : ModTile
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
            dustType = 1;
            drop = mod.ItemType("Nickel");
            Color color = new Color(209, 211, 217);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Nickel");
            AddMapEntry(color, name);
            minPick = 35;
            mineResist = 3f;
        }
    }
}
