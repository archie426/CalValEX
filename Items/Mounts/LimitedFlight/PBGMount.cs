using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Mounts.LimitedFlight
{
    public class PBGMount : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.buff = mod.BuffType("PBGMountBuff");
            mountData.heightBoost = 5;
            mountData.fallDamage = 0f;
            mountData.runSpeed = 7f;
            mountData.dashSpeed = 3f;
            mountData.flightTimeMax = 195;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 6;
            mountData.acceleration = 0.35f;
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            mountData.spawnDust = calamityMod.DustType("BloomTileLeaves");
            mountData.jumpSpeed = 5f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 12;
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 9; // (increase this?)
            }
            mountData.playerYOffsets = array;
            mountData.xOffset = 4;
            mountData.bodyFrame = 6;
            mountData.yOffset = 4;
            mountData.playerHeadOffset = 0;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 1;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 4;
            mountData.runningFrameDelay = 15;
            mountData.runningFrameStart = 1;
            // if (Main.player.velocity.X = mountData.runSpeed) {
            // mountData.runningFrameCount = 1;
            // mountData.runningFrameDelay = 12;
            // mountData.runningFrameStart = 8;
            // } I forgot what this is for
            mountData.flyingFrameCount = 3;
            mountData.flyingFrameDelay = 8;
            mountData.flyingFrameStart = 5;
            mountData.inAirFrameCount = 4;
            mountData.inAirFrameDelay = 8;
            mountData.inAirFrameStart = 8;
            mountData.idleFrameCount = 1;
            mountData.idleFrameDelay = 1;
            mountData.idleFrameStart = 4;
            mountData.idleFrameLoop = false;
            mountData.swimFrameCount = 1;
            mountData.swimFrameDelay = 40;
            mountData.swimFrameStart = 0;
            if (Main.netMode == NetmodeID.Server)
            {
                return;
            }

            mountData.textureWidth = mountData.frontTexture.Width;
            mountData.textureHeight = mountData.frontTexture.Height;
        }
    }
}