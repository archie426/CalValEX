using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Items.Tiles.Blocks.Astral;
using CalValEX.Tiles.FurnitureSets.Astral;

namespace CalValEX.Items.Tiles.FurnitureSets.Astral
{
    public class OldAstralLampItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenomonolith Lamp");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = ModContent.TileType<OldAstralLamp>();
            item.width = 12;
            item.height = 12;
            item.rare = 0;
        }

        public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<AstralTreeWood>(), 3);
                recipe.AddTile(mod.TileType("StarstruckSynthesizerPlaced"));
                recipe.SetResult(this);
                recipe.AddRecipe();

                ModRecipe recipe2 = new ModRecipe(mod);
                recipe2.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MonolithLamp"));
                recipe2.AddTile(mod.TileType("StarstruckSynthesizerPlaced"));
                recipe2.SetResult(this);
                recipe2.AddRecipe();
            }
        }
    }
}