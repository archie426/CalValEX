﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Buffs.LightPets
{
    public class YeetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Litfish");
            Description.SetDefault("A baby sunskater will follow you now.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.lightPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            Mod clamMod = ModLoader.GetMod("CalamityMod");
            clamMod.Call("AddAbyssLightStrength", Main.player[Main.myPlayer], 1);
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().Skeetyeet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Skeetyeet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2,
                    0f, 0f, mod.ProjectileType("Skeetyeet"), 0, 0f, player.whoAmI);
            }
        }
    }
}