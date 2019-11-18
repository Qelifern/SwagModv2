using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace SwagModv2.Items.Tools
{
    public class MalachitePick : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Pickaxe");
            Tooltip.SetDefault("Able to mine Cuprite.");
        }
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 8;
            item.useTime = 6;
            item.autoReuse = true;
            item.width = 38;
            item.height = 38;
            item.damage = 188;
            item.pick = 245;
            item.UseSound = SoundID.Item1;
            item.knockBack = 6f;
            item.rare = 9;
            item.value = Item.sellPrice(0, 54, 0, 0);
            item.scale = 1.15f;
            item.melee = true;
            item.tileBoost += 6;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("MalachiteBar"), 18);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
