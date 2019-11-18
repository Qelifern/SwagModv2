using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace SwagModv2
{
    public class SwagWorldGen : ModWorld
    {

        /*
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != 1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Swaggin the world.", delegate (GenerationProgress progress)
                {
                    progress.Message = "Swaggin the ores.";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 12E-05); i++)
                    {
                        WorldGen.OreRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX),
                            WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200),
                            (double)WorldGen.genRand.Next(5, 8),
                            WorldGen.genRand.Next(2, 6),
                            (ushort)mod.TileType("TileNickelOre"));
                    }
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayerHigh * Main.maxTilesY) * 24E-05); k++)
                    {
                        int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int y = WorldGen.genRand.Next((int)WorldGen.rockLayerHigh, Main.maxTilesY - 200);
                        WorldGen.OreRunner(x, y, WorldGen.genRand.Next(8, 10), WorldGen.genRand.Next(7, 11), (ushort)mod.TileType("TileMalachiteOre"));
                    }
                    for (int i = 0; i < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 24E-05); i++)
                    {
                        int xx = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int yy = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200);
                        WorldGen.OreRunner(xx, yy, WorldGen.genRand.Next(8, 10), WorldGen.genRand.Next(7, 11), (ushort)mod.TileType("TileCupriteOre"));
                    }
                    for (int d = 0; d < (int)((double)(WorldGen.rockLayerLow * Main.maxTilesY) * 24E-05); d++)
                    {
                        int xxd = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int yyd = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY - 200);
                        WorldGen.OreRunner(xxd, yyd, WorldGen.genRand.Next(8, 10), WorldGen.genRand.Next(7, 11), (ushort)mod.TileType("TileSwagiantiumOre"));
                    }
                }));
            }
        }
        */
    }
}
