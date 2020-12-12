﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Tiles.Walls;
using CalValEX.Items.Tiles.Blocks;

namespace CalValEX.Items.Tiles.Walls
{
	public class PlagueHiveWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plague Hive Wall");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 0;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createWall = ModContent.WallType<PlagueHiveWallPlaced>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			recipe.AddIngredient(calamityMod.ItemType("PlagueCellCluster"), 1);
			recipe.AddIngredient(ItemID.HiveWall);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}