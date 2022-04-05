using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Critters;

namespace CalValEX.NPCs.Critters
{
    public class CrystalFly : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Profaned Butterfly");
            Main.npcFrameCount[NPC.type] = 3;
            Main.npcCatchable[NPC.type] = true;
        }

        public override void SetDefaults()
        {
            NPC.width = 48;
            NPC.height = 40;
            NPC.aiStyle = 65;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.lifeMax = 5;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.npcSlots = 0.25f;
            NPC.noGravity = true;

            NPC.catchItem = (short)ItemType<CrystalFlyItem>();
            NPC.lavaImmune = true;
            NPC.friendly = true; // We have to add this and CanBeHitByItem/CanBeHitByProjectile because of reasons.
            AIType = NPCID.GoldButterfly;
            AnimationType = NPCID.GoldButterfly;
            NPC.lifeMax = 20;
            for (int i = 0; i < NPC.buffImmune.Length; i++)
            {
                //NPC.buffImmune[(ModLoader.GetMod("CalamityMod").BuffType("Holy Flames"))] = false;
            }
        }

        public override void SetBestiary(Terraria.GameContent.Bestiary.BestiaryDatabase database, Terraria.GameContent.Bestiary.BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.UIInfoProvider = new Terraria.GameContent.Bestiary.CommonEnemyUICollectionInfoProvider(ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[Type], quickUnlock: true);
            bestiaryEntry.Info.AddRange(new Terraria.GameContent.Bestiary.IBestiaryInfoElement[] {
                Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheHallow,
                new Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement("A butterfly possessing energy from one of two halves of a fiery goddess' power."),
            });
        }

        public override bool? CanBeHitByItem(Player player, Item item)
        {
            return true;
        }

        public override bool? CanBeHitByProjectile(Projectile projectile)
        {
            return true;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.playerSafe || !NPC.downedMoonlord || CalValEXConfig.Instance.CritterSpawns)
            {
                return 0f;
            }
            return Terraria.ModLoader.Utilities.SpawnCondition.OverworldHallow.Chance * 0.4f;
        }

        public override void OnCatchNPC(Player player, Item item)
        {
            item.stack = 1;
        }

        // TODO: Hooks for Collision_MoveSnailOnSlopes and NPC.aiStyle = 67 problem
    }
}