using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalValEX;
using CalValEX.Items.Pets;
using CalValEX.Items.Hooks;

namespace CalValEX.Items.Equips
{

[AutoloadEquip(EquipType.Balloon)]
public class AuricBalloon : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("'You're lucky I didn't make you get every other balloon for this.'");
	}

	public override void SetDefaults()
	{
		item.width = 24;
		item.height = 42;
		item.value = Item.sellPrice(0, 60, 0, 0);
		item.rare = 11;
		item.accessory = true;
		item.vanity = true;
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
            tooltipLine.overrideColor = new Color(108, 45, 199); //change the color accordingly to above
        }
    }
}

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
            	Mod calamityMod = ModLoader.GetMod("CalamityMod");
                if (calamityMod != null)
                {

               		recipe.AddIngredient(calamityMod.ItemType("AuricBar"), 4);
                	recipe.AddIngredient((ItemID.PartyBundleOfBalloonsAccessory), 1);
                	recipe.AddTile(calamityMod.TileType("DraedonsForge"));
                        recipe.SetResult(this);
                        recipe.AddRecipe();
				}
			}
}
}