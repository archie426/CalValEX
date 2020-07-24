using CalValEX.Items.Tiles;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace CalValEX.Items.Tiles
{
	public class ViolemurBanner : ModItem
	{
		// The tooltip for this item is automatically assigned from .lang files
		public override void SetDefaults() {
			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.rare = 4;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.createTile = TileType<ViolemurBannerPlaced>();
			item.placeStyle = 0;
		}
	}
}