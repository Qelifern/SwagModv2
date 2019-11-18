using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwagModv2.Items.Bars
{
    public class MalachiteBar : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Bar");
        }


        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.value = Item.sellPrice(0, 40, 0, 0);
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("TileMalachiteBar");
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("Malachite"), 3);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
