﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Buffs.Pets.Elementals
{
    public class RareSsandBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Small Sand Elemental");
            Description.SetDefault("She can't heal you, but she's doing her best.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().raresandmini = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("RaresandMini")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("RaresandMini"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}