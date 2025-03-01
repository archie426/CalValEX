﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Shirts.AresChestplate
{
    public class GaussArm : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nuke arm");
        }

        public override void SetDefaults()
        {
            projectile.width = 104;
            projectile.height = 104;
            projectile.friendly = true;
            projectile.timeLeft = 18000;
            projectile.aiStyle = -1;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            projectile.position.X = player.position.X + 60;
            projectile.position.Y = player.position.Y - 110;

            if (modPlayer.aresarms)
            {
                projectile.timeLeft = 18000;
            }
            else
            {
                projectile.active = false;
            }
            projectile.rotation = projectile.AngleTo(Main.MouseWorld);
            //projectile.spriteDirection = player.direction;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Player player = Main.player[projectile.owner];
            Vector2 distToProj = new Vector2(projectile.Center.X, projectile.Center.Y);
            float projRotation = projectile.AngleTo(player.MountedCenter) - 1.57f;
            bool doIDraw = true;
            Texture2D texture = mod.GetTexture("Items/Equips/Shirts/AresChestplate/AresTube"); //change this accordingly to your chain texture

            while (doIDraw)
            {
                float distance = (player.MountedCenter - distToProj).Length();
                if (distance < (texture.Height + 1))
                {
                    doIDraw = false;
                }
                else if (!float.IsNaN(distance))
                {
                    Color drawColor = Lighting.GetColor((int)distToProj.X / 16, (int)(distToProj.Y / 16f));
                    distToProj += projectile.DirectionTo(player.MountedCenter) * texture.Height;
                    spriteBatch.Draw(texture, distToProj - Main.screenPosition,
                        new Rectangle(0, 0, texture.Width, texture.Height), drawColor, projRotation,
                        Utils.Size(texture) / 2f, 1f, SpriteEffects.None, 0f);
                }
            }
            return true;
        }
    }
}