using CalValEX.Buffs.LightPets;
using CalValEX.Buffs.Pets;
using CalValEX.Items;
using CalValEX.Items.Critters;
using CalValEX.Items.Equips.Balloons;
using CalValEX.Items.Equips.Hats;
using CalValEX.Items.Equips.Legs;
using CalValEX.Items.Equips.Scarves;
using CalValEX.Items.Equips.Shields;
using CalValEX.Items.Equips.Shirts;
using CalValEX.Items.Equips.Transformations;
using CalValEX.Items.Equips.Wings;
using CalValEX.Items.Hooks;
using CalValEX.Items.LightPets;
using CalValEX.Buffs.Mounts;
using CalValEX.Items.Mounts.InfiniteFlight;
using CalValEX.Items.Mounts.Ground;
using CalValEX.Items.Mounts.LimitedFlight;
using CalValEX.Items.Pets;
using CalValEX.Items.Pets.Elementals;
using CalValEX.Items.Tiles;
using CalValEX.Items.Tiles.Blocks;
using CalValEX.Items.Tiles.FurnitureSets.Bloodstone;
using CalValEX.Tiles.Blocks;
using CalValEX.Tiles;
using CalValEX.Tiles.MiscFurniture;
using CalValEX.Items.Tiles.Monoliths;
using CalValEX.Items.Tiles.Paintings;
using CalValEX.Items.Tiles.Plants;
using CalValEX.Items.Tiles.Statues;
using CalamityMod.World;
using CalValEX.AprilFools;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CalValEX
{
    public class CalValEXGlobalitem : GlobalItem
    {
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;

        public override void SetDefaults(Item item)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (item.type == calamityMod.ItemType("Bloodstone"))
            {
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.createTile = ModContent.TileType<BloodstonePlaced>();
            }
            if (item.type == calamityMod.ItemType("MeldiateBar"))
            {
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.createTile = ModContent.TileType<MeldConstructPlaced>();
            }
            if (item.type == calamityMod.ItemType("EyeofExtinction"))
            {
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.createTile = ModContent.TileType<CeremonialUrnPlaced>();
            }
            if (item.type == calamityMod.ItemType("SCalBag"))
            {
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.createTile = ModContent.TileType<CalamitasCofferPlaced>();
            }
            if (item.type == calamityMod.ItemType("DraedonTreasureBag"))
            {
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.createTile = ModContent.TileType<DraedonQuoteonQuoteBagPlaced>();
            }
        }

        public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            Mod orthoceraDLC = ModLoader.GetMod("CalValPlus");
            bool april = (CalValEX.month == 4 && (CalValEX.day == 1 || CalValEX.day == 2 || CalValEX.day == 3 || CalValEX.day == 4 || CalValEX.day == 5 || CalValEX.day == 6 || CalValEX.day == 7));
            if (orthoceraDLC != null || april)
            {
                if (item.type == calamityMod.ItemType("CosmicDischarge"))
                {
                    item.damage = item.damage + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("SHPC"))
                {
                    item.damage = item.damage + (NPC.downedMechBoss1 ? 0 : 1)
                        + (NPC.downedMechBoss2 ? 0 : 1) + (NPC.downedMechBoss3 ? 0 : 1)
                        + (NPC.downedPlantBoss ? 0 : 1) + (NPC.downedGolemBoss ? 0 : 1)
                        + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("BlossomFlux"))
                {
                    item.damage = item.damage + (NPC.downedGolemBoss ? 0 : 1)
                        + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("Malachite"))
                {
                    item.damage = item.damage + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("AegisBlade"))
                {
                    item.damage = item.damage + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("BrinyBaron"))
                {
                    item.damage = item.damage + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("Vesuvius"))
                {
                    item.damage = item.damage + (NPC.downedMoonlord ? 0 : 1)
                        + ((bool)calamityMod.Call("GetBossDowned", "providence") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "devourerofgods") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "yharon") ? 1 : 0)
                        + ((bool)calamityMod.Call("GetBossDowned", "supremecalamitas") ? 1 : 0);
                }
                else if (item.type == calamityMod.ItemType("ElementalBlaster"))
                {
                    item.damage = item.damage + 1;
                }
            }
        }

        public override void ArmorSetShadows(Player player, string set)
        {
            if (player.GetModPlayer<CalValEXPlayer>().cassette)
            {
                player.armorEffectDrawShadow = true;
                player.armorEffectDrawOutlines = true;
            }
        }

        public override void RightClick(Item item, Player player)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (!CalValEXConfig.Instance.DisableVanityDrops)
            {
                if (item.type == calamityMod.ItemType("StarterBag"))
                {
                    if (player.whoAmI == Main.myPlayer)
                    {
                        Mod orthoceraDLC = ModLoader.GetMod("CalValPlus");
                        if (CalValEX.month == 4 && (CalValEX.day == 1 || CalValEX.day == 2 || CalValEX.day == 3 || CalValEX.day == 4 || CalValEX.day == 5 || CalValEX.day == 6 || CalValEX.day == 7))
                        {
                            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, ModContent.NPCType<AprilFools.Jharim.Jharim>(), 0, 0f, 0f, 0f, 0f, 255);	
                        }
                        else if (orthoceraDLC != null)
                        {
                            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, ModContent.NPCType< AprilFools.Jharim.Jharim>(), 0, 0f, 0f, 0f, 0f, 255);
                        }
                        player.QuickSpawnItem(ModContent.ItemType<C>());
                        switch (player.name)
                        {
                            case "Jared":
                                player.QuickSpawnItem(ModContent.ItemType<EWail>());
                                player.QuickSpawnItem(ModContent.ItemType<SoulShard>());
                                break;

                            case "RamG":
                            case "Ramgear":
                                player.QuickSpawnItem(ModContent.ItemType<ToyScythe>());
                                break;

                            case "Bumbledoge":
                            case "BumbleDoge":
                            case "Bojangles":
                            case "Bojeangles":
                                player.QuickSpawnItem(ModContent.ItemType<AeroPebble>());
                                player.QuickSpawnItem(ModContent.ItemType<FluffyFur>());
                                break;

                            case "William":
                                player.QuickSpawnItem(ModContent.ItemType<EurosBandage>());
                                break;

                            case "Kiwabug":
                                player.QuickSpawnItem(ModContent.ItemType<UglyTentacle>());
                                break;

                            case "YuH":
                            case "Yuh":
                            case "yuh":
                            case "Lilsigtum":
                            case "GinYuH":
                            case "Lil Sigtum":
                                player.QuickSpawnItem(ModContent.ItemType<FlareRune>());
                                player.QuickSpawnItem(ModContent.ItemType<Eidolistthingy>());
                                break;

                            case "Hypera":
                                player.QuickSpawnItem(ModContent.ItemType<SolarBun>());
                                break;

                            case "Drakudragonx":
                                player.QuickSpawnItem(ModContent.ItemType<BambooStick>());
                                break;

                            case "Spider":
                            case "spider":
                            case "Spooktacular":
                            case "spooktacular":
                                player.QuickSpawnItem(ModContent.ItemType<IsopodItem>(), 5);
                                break;

                            case "Fabsol":
                                player.QuickSpawnItem(ModContent.ItemType<DogPetItem>());
                                break;

                            case "Lucca":
                                player.QuickSpawnItem(ModContent.ItemType<JunkoHat>());
                                player.QuickSpawnItem(ModContent.ItemType<ToyScythe>());
                                break;

                            case "Junko":
                                player.QuickSpawnItem(ModContent.ItemType<JunkoHat>());
                                player.QuickSpawnItem(ModContent.ItemType<ToyScythe>());
                                player.QuickSpawnItem(ModContent.ItemType<ProfanedBalloon>());
                                break;

                            case "Lil Junko":
                                player.QuickSpawnItem(ModContent.ItemType<JunkoHat>());
                                break;

                            case "Cooper":
                                player.QuickSpawnItem(ModContent.ItemType<coopershortsword>());
                                break;

                            case "Tess":
                                player.QuickSpawnItem(ModContent.ItemType<AstralStar>());
                                break;

                            case "Enreden":
                                player.QuickSpawnItem(ModContent.ItemType<Enredenitem>());
                                break;

                            case "Iban":
                            case "IbanPlay":
                            case "IBlockaroz":
                                player.QuickSpawnItem(ModContent.ItemType<ProtoRing>());
                                break;

                            case "Mathew":
                            case "Mathew Maple":
                            case "Maple":
                                player.QuickSpawnItem(ModContent.ItemType<DeepseaLantern>());
                                player.QuickSpawnItem(ModContent.ItemType<SwearingShroom>());
                                player.QuickSpawnItem(ModContent.ItemType<FleshThing>());
                                break;

                            case "Emerald":
                            case "EmeraldXLapis":
                                player.QuickSpawnItem(ModContent.ItemType<FogG>());
                                break;

                            case "Yharex87":
                            case "Yharex":
                                player.QuickSpawnItem(ModContent.ItemType<JellyBottle>());
                                player.QuickSpawnItem(ModContent.ItemType<YharexsLetter>());
                                break;

                            case "Scarfy":
                            case "ScarfyScout":
                            case "Krysmun":
                            case "DodoNation":
                            case "Dodo":
                                player.QuickSpawnItem(ModContent.ItemType<FluffyFeather>());
                                break;

                            case "caligulasAquarium":
                            case "caligulas":
                                player.QuickSpawnItem(ModContent.ItemType<Ectogasm>());
                                break;

                            case "Willow":
                            case "willowmaine":
                            case "bean long":
                                player.QuickSpawnItem(ModContent.ItemType<OldMirage>());
                                player.QuickSpawnItem(ModContent.ItemType<PerennialFlower>());
                                player.QuickSpawnItem(ModContent.ItemType<VVanities>());
                                break;

                            case "Potato Person":
                                player.QuickSpawnItem(ModContent.ItemType<MissingFang>());
                                break;

                            case "Dorira":
                            case "Marco":
                                player.QuickSpawnItem(ModContent.ItemType<CharredChopper>());
                                player.QuickSpawnItem(ModContent.ItemType<RapturedWormScarf>());
                                break;

                            case "Hat Enthusiast":
                                player.QuickSpawnItem(ModContent.ItemType<InkyArtifact>());
                                break;
                                
                            case "Triangle":
                                player.QuickSpawnItem(ModContent.ItemType<BubbledFin>());
                                player.QuickSpawnItem(ModContent.ItemType<GoozmaPetItem>());
                                break;

                            case "Brimmy":
                                player.QuickSpawnItem(ModContent.ItemType<BurningEye>());
                                player.QuickSpawnItem(ModContent.ItemType<FoilSpoon>());
                                player.QuickSpawnItem(ModContent.ItemType<brimtulip>());
                                break;
                        }
                    }
                }

                if (item.type == calamityMod.ItemType("AbyssalCrate"))
                {
                    if (Main.rand.NextFloat() < 0.01f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<AcidGun>());
                    }

                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<CursedLockpick>());
                    }

                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SulphurColumn>(), Main.rand.Next(5, 7));
                    }

                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SulphurGeyser>(), Main.rand.Next(2, 3));
                    }

                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SulphurousCactus>(), Main.rand.Next(1, 3));
                    }

                    if (Main.rand.NextFloat() < 0.04f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SulphurousPlanter>(), 1);
                    }

                    if ((bool) calamityMod.Call("GetBossDowned", "calamitas") & (Main.rand.NextFloat() < 0.02f))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<Pollution>());
                    }

                    if ((bool) calamityMod.Call("GetBossDowned", "polterghast") & (Main.rand.NextFloat() < 0.025f))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<EidolonTree>());
                    }

                    if ((bool) calamityMod.Call("GetBossDowned", "oldduke") & (Main.rand.NextFloat() < 0.1f))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<NuclearFumes>(), Main.rand.Next(2, 11));
                    }

                    if ((bool) calamityMod.Call("GetBossDowned", "aquaticscourge") & (Main.rand.NextFloat() < 0.05f))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<BelchingCoral>());
                    }
                }

                if (item.type == calamityMod.ItemType("AstralCrate"))
                {
                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<MonolithPot>());
                    }

                    if ((bool) calamityMod.Call("GetBossDowned", "signus") & (Main.rand.NextFloat() < 0.05f))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<NetherTree>());
                    }
                }

                if (item.type == calamityMod.ItemType("SunkenCrate"))
                {
                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SSCoral>());
                    }

                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<Anemone>());
                    }

                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<TableCoral>());
                    }

                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<FanCoral>());
                    }

                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<BrainCoral>());
                    }

                    if (Main.rand.NextFloat() < 0.01f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SeaCrown>());
                    }

                    if (Main.rand.NextFloat() < 0.025f)
                    {
                        player.QuickSpawnItem(ModContent.ItemType<SunkenLamp>());
                    }
                }
            }
        }

        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            Mod catalyst = ModLoader.GetMod("CatalystMod");

            if (context == "bossBag")
            {
                if (calamityMod != null)
                {
                    if (!CalValEXConfig.Instance.DisableVanityDrops)
                    {
                        //Here is a list of all Calamity Bags:
                        //Aquatic Scourge = AquaticScourgeBag
                        //Astrum Aureus = AstrageldonBag
                        //Astrum Deus = AstrumDeusBag
                        //Brimstone Elemental = BrimstoneWaifuBag
                        //Dragonfolly = BumblebirbBag
                        //Calamitas = CalamitasBag
                        //Crabulon = CrabulonBag
                        //Cryogen = CryogenBag
                        //Desert Scourge = DesertScourgeBag
                        //Devourer of Gods = DevourerofGodsBag
                        //Hive Mind = HiveMindBag
                        //Leviathan and Siren = LeviathanBag
                        //Old Duke = OldDukeBag
                        //Perforators = PerforatorBag
                        //Plaguebringer Goliath = PlaguebringerGoliathBag
                        //Polterghast = PolterghastBag
                        //Providence = ProvidenceBag
                        //Ravager = RavagerBag
                        //Slime God = SlimeGodBag
                        //Starter Bag = StarterBag
                        //Yharon = YharonBag

                        if (arg == calamityMod.ItemType("StarterBag"))
                        {
                            player.QuickSpawnItem(ModContent.ItemType<C>());
                        }

                        if (arg == calamityMod.ItemType("DesertScourgeBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DesertMedallion>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DriedMandible>());
                            }

                            if (Main.rand.NextFloat() < 0.07f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SandTooth>());
                            }
                        }

                        if (arg == calamityMod.ItemType("CrabulonBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<ClawShroom>());
                            }
                        }

                        if (arg == calamityMod.ItemType("HiveMindBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<MissingFang>());
                            }
                        }

                        if (arg == calamityMod.ItemType("PerforatorBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DigestedWormFood>());
                            }

                            if (Main.rand.NextFloat() < 0.4f)
                            {
                                int choice = Main.rand.Next(3);
                                if (choice == 0)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<SmallWorm>());
                                }
                                if (choice == 1)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<MidWorm>());
                                }
                                else
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<BigWorm>());
                                }
                            }
                        }

                        if (arg == calamityMod.ItemType("SlimeGodBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("StatigelBlock"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<ImpureStick>());
                            }
                        }

                        if (arg == calamityMod.ItemType("CryogenBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<CryoStick>());
                            }
                        }

                        if (arg == calamityMod.ItemType("AquaticScourgeBag"))
                        {
                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AquaticHide>());
                            }
                        }

                        if (arg == calamityMod.ItemType("BrimstoneWaifuBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("BrimstoneSlag"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<BrimmyBody>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<BrimmySpirit>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<brimtulip>());
                            }

                            if (Main.rand.NextFloat() < 0.05f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<FoilSpoon>());
                            }
                        }

                        if (arg == calamityMod.ItemType("CalamitasBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Calacirclet>());
                            }

                            if (Main.rand.NextFloat() < 0.001f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }

                            if ((bool)calamityMod.Call("GetBossDowned", "providence") && Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadeHood>(), 1);
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadeRobe>(), 1);
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadePants>(), 1);
                            }
                        }

                        if (arg == calamityMod.ItemType("LeviathanBag"))
                        {
                            if (Main.rand.NextFloat() < 0.15f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AquaticMonolith>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<LeviWings>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<LeviathanEgg>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<FoilAtlantis>());
                            }

                            if (Main.rand.NextFloat() < 0.01f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<WetBubble>());
                            }
                        }

                        if (arg == calamityMod.ItemType("AstrageldonBag"))
                        {
                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AstDie>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AureusShield>());
                            }

                            if (Main.rand.NextFloat() < 0.001f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                        if (arg == calamityMod.ItemType("PlaguebringerGoliathBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlate"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.004f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<InfectedController>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<PlaguePack>());
                            }

                            if (Main.rand.NextFloat() < 0.33f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<PlagueHiveWand>());
                            }
                        }

                        if (arg == calamityMod.ItemType("RavagerBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Necrostone>(), Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientChoker>());
                            }

                            if (Main.rand.NextFloat() < 0.07f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<ScavaHook>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<RavaHook>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SkullBalloon>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<StonePile>());
                            }
                        }

                        if (arg == calamityMod.ItemType("AstrumDeusBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AstralStar>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AstBandana>());
                            }
                        }

                        if (arg == calamityMod.ItemType("BumblebirbBag"))
                        {
                            if ((bool) calamityMod.Call("GetBossDowned", "yharon") &&
                                !CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("SilvaCrystal"),
                                    Main.rand.Next(205, 335));
                            }

                            int choice = Main.rand.Next(3);
                            if (choice == 0)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<FollyWings>());
                            }
                            else if (choice == 1)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Birbhat>());
                            }
                            else
                            {
                                player.QuickSpawnItem(ModContent.ItemType<FollyWing>());
                            }

                            if (Main.rand.NextFloat() < 0.005f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                        if (arg == calamityMod.ItemType("ProvidenceBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("ProfanedRock"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<ProShard>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<ProviCrystal>());
                            }
                        }

                        if (arg == calamityMod.ItemType("StormWeaverBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks && (bool)calamityMod.Call("GetBossDowned", "devourerofgods"))
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("OccultStone"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<WeaverFlesh>());
                                }
                                else
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<ShellScrap>());
                                }
                            }
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<StormBandana>());
                            }
                            if (Main.rand.NextFloat() < 0.007f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                        if (arg == calamityMod.ItemType("CeaselessVoidBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks && (bool)calamityMod.Call("GetBossDowned", "devourerofgods"))
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("OccultStone"),
                                    Main.rand.Next(205, 335));
                            }
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<VoidShard>());
                            }
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<VoidWings>());
                            }
                            if (Main.rand.NextFloat() < 0.05f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<OldVoidWings>());
                            }
                            if (Main.rand.NextFloat() < 0.007f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                        if (arg == calamityMod.ItemType("SignusBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks && (bool)calamityMod.Call("GetBossDowned", "devourerofgods"))
                            {
                                player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("OccultStone"),
                                    Main.rand.Next(205, 335));
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SigCloth>());
                            }

                            int choice = Main.rand.Next(4);
                            if (choice == 0)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SignusEmblem>());
                            }
                            else if (choice == 1)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SignusNether>());
                            }
                            else if (choice == 2)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<SignusBalloon>());
                            }
                            else
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Items.Equips.Capes.SigCape>());
                            }
                            if (Main.rand.NextFloat() < 0.007f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                            if (arg == calamityMod.ItemType("PolterghastBag"))
                        {
                            if (!CalValEXConfig.Instance.ConfigBossBlocks)
                            {
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModLoader.GetMod("CalamityMod").ItemType("StratusBricks"),
                                        Main.rand.Next(205, 335));
                                }
                                else
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<PhantowaxBlock>(),
                                        Main.rand.Next(205, 335));
                                }
                            }

                            if (Main.rand.NextFloat() < 0.1f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Polterhook>());
                            }
                        }

                        if (arg == calamityMod.ItemType("OldDukeBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<OldWings>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<CorrodedCleaver>());
                            }

                            if (Main.rand.NextFloat() < 0.07f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<CharredChopper>());
                            }
                        }

                        if (arg == calamityMod.ItemType("DevourerofGodsBag"))
                        {
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<CosmicWormScarf>());
                            }

                            if (Main.rand.NextFloat() < 0.2f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DogPetItem>());
                            }

                            if (Main.rand.NextFloat() < 0.07f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<RapturedWormScarf>());
                            }

                            if (Main.rand.NextFloat() < 0.01f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                        }

                        if (arg == calamityMod.ItemType("YharonBag"))
                        {
                            player.QuickSpawnItem(ModContent.ItemType<Termipebbles>(), Main.rand.Next(5, 8));
                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<JunglePhoenixWings>());
                            }

                            if (Main.rand.NextFloat() < 0.3f && !(CalValEX.month == 6 && CalValEX.day == 1))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<YharonsAnklet>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<NuggetBiscuit>());
                            }

                            if (Main.rand.NextFloat() < 0.3f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<YharonShackle>());
                            }

                            if (Main.rand.NextFloat() < 0.05f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }

                            if (Main.rand.NextFloat() < 0.1f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadeHood>());
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadeRobe>());
                                player.QuickSpawnItem(ModContent.ItemType<DemonshadePants>());
                            }
                        }

                        if (arg == calamityMod.ItemType("DraedonTreasureBag"))
                        {
                            if (CalamityWorld.downedThanatos)
                            {
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<XMLightningHook>());
                                }
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<Items.Pets.ExoMechs.GunmetalRemote>());
                                }
                            }
                            if (CalamityWorld.downedArtemisAndApollo)
                            {
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<ApolloBalloonSmall>());
                                    player.QuickSpawnItem(ModContent.ItemType<ArtemisBalloonSmall>());
                                }
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<Items.Pets.ExoMechs.GeminiMarkImplants>());
                                }
                            }
                            if (CalamityWorld.downedAres)
                            {
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<Items.Equips.Shirts.AresChestplate.AresChestplate>());
                                }
                                if (Main.rand.NextFloat() < 0.5f)
                                {
                                    player.QuickSpawnItem(ModContent.ItemType<Items.Pets.ExoMechs.OminousCore>());
                                }
                            }
                            if (Main.rand.NextFloat() < 0.1f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                            if (Main.rand.NextFloat() < 0.14f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<DraedonBody>());
                                player.QuickSpawnItem(ModContent.ItemType<DraedonLegs>());
                            }
                        }

                        if (arg == calamityMod.ItemType("SCalBag"))
                        {
                            if (Main.rand.NextFloat() < 0.1f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<AncientAuricTeslaHelm>());
                            }
                            if (Main.rand.NextFloat() < 0.33f)
                            {
                                player.QuickSpawnItem(ModContent.ItemType<GruelingMask>());
                            }
                        }
                    }
                }
                if (catalyst != null)
                {
                    if (arg == catalyst.ItemType("AstrageldonBag"))
                    {
                        if (Main.rand.NextFloat() < 0.3f)
                        {
                            player.QuickSpawnItem(ModContent.ItemType<JellyBottle>());
                        }
                    }
                }
            }
        }

        public void DeleteRecipes(int item)
        {
            RecipeFinder val = new RecipeFinder();
            val.SetResult(item);
            foreach (Recipe item2 in val.SearchRecipes()) new RecipeEditor(item2).DeleteRecipe();
        }

        public override void AddRecipes()
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            DeleteRecipes(calamityMod.ItemType("AuricToilet"));
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<CosmiliteChairEX>());
            recipe.AddIngredient(ModContent.ItemType<BloodstoneChairItem>());
            recipe.AddIngredient(calamityMod.ItemType("BotanicChair"));
            recipe.AddIngredient(calamityMod.ItemType("SilvaChair"));
            recipe.AddIngredient(calamityMod.ItemType("AuricBar"), 4);
            recipe.AddTile(ModContent.TileType<Tiles.FurnitureSets.Auric.AuricManufacturerPlaced>());
            recipe.SetResult(calamityMod.ItemType("AuricToilet"));
            recipe.AddRecipe();
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if ((head.type == calamityMod.ItemType("WulfrumHelmet") ||
                 head.type == calamityMod.ItemType("WulfrumHelm") ||
                 head.type == calamityMod.ItemType("WulfrumHeadgear") ||
                 head.type == calamityMod.ItemType("WulfrumHood") ||
                 head.type == calamityMod.ItemType("WulfrumMask")) &&
                body.type == calamityMod.ItemType("WulfrumArmor") &&
                legs.type == calamityMod.ItemType("WulfrumLeggings"))
            {
                return "Wulfrumset";
            }

            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (player.HasBuff(ModContent.BuffType<PylonBuff>()) &&
                player.HasBuff(ModContent.BuffType<WulfrumArmy>()) &&
                player.HasBuff(ModContent.BuffType<TractorMount>()) && set == "Wulfrumset")
            {
                CalValEX.WulfrumsetReal = true;
            }
            else
            {
                CalValEX.WulfrumsetReal = false;
            }
        }
    }
}
