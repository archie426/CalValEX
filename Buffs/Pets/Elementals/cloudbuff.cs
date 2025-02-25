﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Buffs.Pets.Elementals
{
    public class cloudbuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Smol Cloud");
            Description.SetDefault("She can't protect you, but she's doing her best.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().cloudmini = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("CloudMini")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("CloudMini"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}