using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.NPCs.Critters;

namespace CalValEX.Items.Critters
{
    public class AstJRItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astragelly Slime");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.maxStack = 999;
            item.consumable = true;
            item.width = 22;
            item.height = 20;
            item.noUseGraphic = true;
            item.makeNPC = (short)NPCType<AstJR>();
            item.rare = ItemRarityID.Lime;
        }
    }
}