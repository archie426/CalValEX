using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using CalValEX.Items.Tiles.FurnitureSets.Phantowax;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalValEX.Tiles.FurnitureSets.Phantowax
{
    public class PhantowaxPlatform : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.CoordinatePadding = 0;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(94, 39, 93));
            drop = ModContent.ItemType<PhantowaxPlatformItem>();
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }
    }
}