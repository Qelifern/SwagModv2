using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items
{
    public class MothronSummon : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Sun Totem");
            Tooltip.SetDefault("Summons Mothron. \nOnly useable while a Solar Eclipse is active.");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 30;
            item.maxStack = 30;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            if (Main.eclipse && Main.dayTime)
            {
                return true;
            }
            return false;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Mothron);
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }



    }
}
