using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SwagModv2.NPCs.Town
{
    [AutoloadHead]
    public class Archmage : ModNPC
    {

        public override bool Autoload(ref string name)
        {
            name = "Archmage";
            return mod.Properties.Autoload;
        }
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Archmage");
            Main.npcFrameCount[npc.type] = 23;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 750;
            NPCID.Sets.AttackType[npc.type] = 2;
            NPCID.Sets.AttackTime[npc.type] = 30;
            NPCID.Sets.AttackAverageChance[npc.type] = 10;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 22;
            npc.height = 54;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Wizard;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            return true;
        }
        public override string TownNPCName()
        {
            switch(WorldGen.genRand.Next(13))
            {
                case 0:
                    return "Antonidas";
                case 1:
                    return "Rex";
                case 2:
                    return "Aethas";
                case 3:
                    return "Dalar";
                case 4:
                    return "Rhonin";
                case 5:
                    return "Khadgar";
                case 6:
                    return "Karlain";
                case 7:
                    return "Ansirem";
                case 8:
                    return "Vargoth";
                case 9:
                    return "Nielas";
                case 10:
                    return "Kel'Thuzad";
                case 11:
                    return "Arugal";
                case 12:
                    return "Alodi";
                default:
                    return "Alodi";
            }
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }
        public override void SetupShop(Chest shop, ref int nextSlot)
        {

            if (NPC.downedPlantBoss && NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank7"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank7"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank7"));
                return;
            }
            else if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank6"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank6"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank6"));
                return;
            }
            else if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank5"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank5"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank5"));
                return;
            }
            else if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank4"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank4"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank4"));
                return;
            }
            else if (NPC.downedBoss2 || NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank3"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank3"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank3"));
                return;
            }
            else if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBoltRank2"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBoltRank2"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissilesRank2"));
                return;
            }
            else
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("FrostBolt"));
                shop.item[nextSlot + 1].SetDefaults(mod.ItemType("ShadowBolt"));
                shop.item[nextSlot + 2].SetDefaults(mod.ItemType("ArcaneMissiles"));
                return;
            }
        }
        public override string GetChat()
        {
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Good day to you!";
                case 1:
                    return !NPC.downedBoss3 ? "Have you seen that old chap a the dungeon?\nHe was talking about some curse." : "Greetings adventurer!";
                case 2:
                    return !NPC.savedWizard ? "Have you seen my brother? Last I heard of him he was in a cave looking for some rare herbs." : "Thanks for saving my brother!";
                case 3:
                    return "Would you like to browse my wares?";
                default:
                    return "Would you like to browse my wares?";

            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 50;
            knockback = 3f;
        }
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 3;
            randExtraCooldown = 5;
        }
        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.BallofFrost;
            attackDelay = 1;
        }
        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 4f;
        }
        public override void TownNPCAttackMagic(ref float auraLightMultiplier)
        {
            auraLightMultiplier = 3f;
        }
    }
}
