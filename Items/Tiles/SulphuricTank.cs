using CalValEX.Items.Equips.Hats;
using CalValEX.Items.Equips.Shields;
using CalValEX.Items.Pets;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using CalValEX.Tiles.MiscFurniture;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Tiles
{
    public class SulphuricTank : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sulphuric Tank");
            Tooltip
                .SetDefault("ZZZX93");
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
            item.createTile = ModContent.TileType<SulphuricTankPlaced>();
            item.width = 12;
            item.height = 12;
            item.rare = 10;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            //rarity 12 (Turquoise) = new Color(0, 255, 200)
            //rarity 13 (Pure Green) = new Color(0, 255, 0)
            //rarity 14 (Dark Blue) = new Color(43, 96, 222)
            //rarity 15 (Violet) = new Color(108, 45, 199)
            //rarity 16 (Hot Pink/Developer) = new Color(255, 0, 255)
            //rarity rainbow (no expert tag on item) = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB)
            //rarity rare variant = new Color(255, 140, 0)
            //rarity dedicated(patron items) = new Color(139, 0, 0)
            //look at https://calamitymod.gamepedia.com/Rarity to know where to use the colors
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.overrideColor = new Color(0, 255, 0); //change the color accordingly to above
                }
            }
        }

        public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<FlakHeadCrab>());
                recipe.AddIngredient(ModContent.ItemType<TrilobiteShield>());
                recipe.AddIngredient(ModContent.ItemType<SkaterEgg>());
                recipe.AddIngredient(ModContent.ItemType<GammaHelmet>());
                recipe.AddIngredient(ModContent.ItemType<NuclearFumes>(), 10);
                recipe.AddIngredient((ItemID.Glass), 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this, 16);
                recipe.AddRecipe();
            }
        }
    }
}