﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.LightPets
{
    public class SkeetCrest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Essence of Yeet");
            Tooltip.SetDefault("'Sunfish gang, sunfish gang.'\n" + "Summons a small Sunskater\n" + "Provides a small amount of light in the abyss");
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.UseSound = SoundID.NPCHit51;
            item.shoot = mod.ProjectileType("Skeetyeet");
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
            item.buffType = mod.BuffType("YeetBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}