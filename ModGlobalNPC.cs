using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using SwagModv2.Items.Accessories;

namespace SwagModv2
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            int twenty = Main.rand.Next(20);

            //Bosses
            if (npc.type == NPCID.Plantera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeFruitFragment"), Main.rand.Next(3, 7));
            }
            if (npc.type == NPCID.Golem)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LunarTabletFragment, Main.rand.Next(4, 12));
            }
            if (twenty <= 5 && npc.type == NPCID.KingSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MSMC"));
            }

            //Solar Eclipse
            if (twenty == 0 && npc.type == NPCID.Eyezor)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Frankenstein)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.SwampThing)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Vampire)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.CreatureFromTheDeep)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Fritz)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Reaper)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.ThePossessed)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Butcher)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.DeadlySphere)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.DrManFly)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Nailhead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }
            if (twenty == 0 && npc.type == NPCID.Psycho)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MothronSummon"));
            }

            // Dungeon

            if (npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesSword)
            {
                if (Main.rand.Next(35) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BerserkerOil"));
                }
            }



            if (npc.type == NPCID.MoonLordCore) 
            {
                if (!SwagWorld.spawnOre)
                {                                                          
                    Main.NewText("The world has been blessed with Malachite", 55, 220, 55);  
                    Main.NewText("The world has been blessed with Cuprite", 200, 100, 55);  
                    Main.NewText("The world has been blessed with Swagiantium", 255, 55, 55);  
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY - 200); 
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("TileMalachiteOre"));  
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("TileMalachiteOre"));  
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("TileMalachiteOre"));   
                    }
                }
                SwagWorld.spawnOre = true;   
            }


        }
    }
}
