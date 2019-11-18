using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace SwagModv2.Items.Tools
{
    public class CupritePick : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cuprite Pickaxe");
            Tooltip.SetDefault("Able to mine Swagiantium.");
        }
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 6;
            item.useTime = 4;
            item.autoReuse = true;
            item.width = 38;
            item.height = 38;
            item.damage = 214;
            item.pick = 255;
            item.UseSound = SoundID.Item1;
            item.knockBack = 6f;
            item.rare = 9;
            item.value = Item.sellPrice(0, 78, 0, 0);
            item.scale = 1.15f;
            item.melee = true;
            item.tileBoost += 8;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("CupriteBar"), 18);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
