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
	[AutoloadEquip(EquipType.Head)]
	public class DevilfishMask2 : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pointed Devil Fish Mask");
            Tooltip
                .SetDefault("Also Edgy");
		}
		public override void SetDefaults() {
			item.width = 28;
			item.height = 20;
			item.rare = 6;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 0, 0);
		}

		public override bool DrawHead() {
			return false;
		}
	}
}