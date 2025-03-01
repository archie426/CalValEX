using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Pets
{
    public class AuricBottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Bottle");
            Tooltip.SetDefault("Summons a Godly Squid to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.UseSound = SoundID.NPCHit13;
            item.shoot = mod.ProjectileType("YharimSquid");
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 11;
            item.buffType = mod.BuffType("YharimSquidBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
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
                    tooltipLine.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB); //change the color accordingly to above
                }
            }
        }

        public override void AddRecipes()
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            {
                {
                    ModRecipe recipe = new ModRecipe(mod);
                    recipe.AddIngredient(calamityMod.ItemType("AuricBar"), 20);
                    recipe.AddIngredient(calamityMod.ItemType("DraedonsExoblade"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("SubsumingVortex"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("Celestus"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("VividClarity"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("MagnomalyCannon"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("HeavenlyGale"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("Photoviscerator"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("ExoGladius"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("CosmicImmaterializer"), 1);
                    recipe.AddIngredient(calamityMod.ItemType("Supernova"), 1);
                    recipe.AddIngredient(mod.ItemType("InkyArtifact"), 1);
                    recipe.AddIngredient(ModContent.ItemType<Items.Equips.Hats.AncientAuricTeslaHelm>(), 1);
                    recipe.AddTile(calamityMod.TileType("DraedonsForge"));
                    recipe.SetResult(this);
                    recipe.AddRecipe();
                }
            }
        }
    }
}