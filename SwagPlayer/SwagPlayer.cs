using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;



namespace SwagModv2.SwagPlayer
{
    public class SwagPlayer : ModPlayer
    {

        public static bool chlorophyteBerserk = false;
        public static bool shadowChase = true;

        public override void OnHitAnything(float x, float y, Entity victim)
        {
            if (player.HeldItem.magic == true)
            {
                if (player.HasBuff(mod.BuffType("Shatter")))
                {
                    player.ClearBuff(mod.BuffType("Shatter"));
                }
            }

            int k = 0;
            for (int l = 0; l < player.armor.Length; l++)
            {
                if (player.armor[l].Name == "Berserker Oil")
                {
                    k = l;
                }
            }
            if (!player.HasBuff(mod.BuffType("UndyingRage")) && !chlorophyteBerserk && ((player.armor[0].Name == "Chlorophyte Berserker Mask" && player.armor[1].Name == "Chlorophyte Plate Mail" && player.armor[2].Name == "Chlorophyte Greaves") || player.armor[k].Name == "Berserker Oil"))
            {
                chlorophyteBerserk = true;
            }
            else
            {
                chlorophyteBerserk = false;
            }
            if (((player.armor[0].Name != "Chlorophyte Berserker Mask" || player.armor[1].Name != "Chlorophyte Plate Mail" || player.armor[2].Name != "Chlorophyte Greaves") && player.armor[k].Name != "Berserker Oil"))
            {
                player.ClearBuff(mod.BuffType("Berserking"));
                player.ClearBuff(mod.BuffType("ShowAnger"));
            }

            if (chlorophyteBerserk)
            {


                if (player.HasBuff(mod.BuffType("Berserking")))
                {
                    player.AddBuff(mod.BuffType("ShowAnger"), 1800);
                    int i = player.FindBuffIndex(mod.BuffType("Berserking"));
                    int j = player.buffTime[i];
                    player.ClearBuff(mod.BuffType("Berserking"));
                    player.AddBuff(mod.BuffType("Berserking"), j - 10);
                }

                if (!player.HasBuff(mod.BuffType("UndyingRage")) && !player.HasBuff(mod.BuffType("Berserking")) && !player.HasBuff(mod.BuffType("ShowAnger")))
                {
                    player.AddBuff(mod.BuffType("ShowAnger"), 1800);
                    player.AddBuff(mod.BuffType("Berserking"), 10800);
                }

            }

        }
    }
}
