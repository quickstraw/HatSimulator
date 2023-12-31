﻿using HatSimulator.Common.Players;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using static Terraria.Mount;

namespace HatSimulator.HatEffects.UnusualLayerEffects
{
    public class FauxDust
    {
        public static Mod mod = HatSimulator.Instance;

        public Vector2 Offset;

        public Player Player { get; set; }
        public Texture2D texture;
        public float scale;
        public Rectangle frame;
        public int alpha;
        public Vector2 velocity;
        public int timer;
        public byte clock;

        public PlayerDrawSet drawInfo;

        public bool active;
        public bool front;

        public Vector2 origin => new Vector2(frame.Width / 2f, frame.Height / 2f);
        public Color Color;

        public FauxDust(PlayerDrawSet info, Vector2 offset, Texture2D texture, float scale)
        {
            HatSimulatorPlayer modPlayer = info.drawPlayer.GetModPlayer<HatSimulatorPlayer>();

            drawInfo = info;
            Player = info.drawPlayer;
            Offset = offset;
            this.texture = texture;
            this.scale = scale;
            frame = new Rectangle(0, 0, texture.Width, texture.Height);
            float vX = Main.rand.NextFloat(-1, 1);
            float vY = Main.rand.NextFloat(-1, 1);
            velocity = new Vector2(vX, vY);
            alpha = 0;
            timer = 0;
            clock = (byte)(modPlayer.counter % 60);
            active = true;
            FindColor();
        }

        public FauxDust(PlayerDrawSet info, Vector2 offset, string texturePath, float scale)
        {
            HatSimulatorPlayer modPlayer = info.drawPlayer.GetModPlayer<HatSimulatorPlayer>();

            drawInfo = info;
            Player = info.drawPlayer;
            Offset = offset;
            texture = ModContent.Request<Texture2D>(texturePath).Value;
            this.scale = scale;
            frame = new Rectangle(0, 0, texture.Width, texture.Height);
            float vX = Main.rand.NextFloat(-1, 1);
            float vY = Main.rand.NextFloat(-1, 1);
            velocity = new Vector2(vX, vY);
            alpha = 0;
            timer = 0;
            clock = (byte) (modPlayer.counter % 60);
            active = true;
            FindColor();
        }

        public virtual void Update()
        {

        }

        public void SafeUpdate()
        {
            byte playerClock = (byte) (Player.GetModPlayer<HatSimulatorPlayer>().counter % 60);
            if (playerClock != clock)
            {
                clock = playerClock;
                Update();
            }
        }

        public DrawData DrawData(PlayerDrawSet info)
        {
            drawInfo = info;
            Player drawPlayer = info.drawPlayer;
            int drawX = (int)(info.Position.X + Player.width / 2f - Main.screenPosition.X);
            int drawY = (int)(info.Position.Y + Player.height / 0.6f - Main.screenPosition.Y);

            if (drawPlayer.mount.Active)
            {
                MountData data = drawPlayer.mount._data;

                Vector2 pos = new Vector2();
                pos.Y += data.heightBoost;

                pos += drawInfo.Position;

                int smoothOffset = (int)(drawInfo.Position - Main.screenPosition - (drawPlayer.position - Main.screenPosition)).Y + data.heightBoost;

                drawX = (int)(pos.X + drawPlayer.width / 2f - Main.screenPosition.X);
                drawY = (int)(pos.Y + 70 - smoothOffset - Main.screenPosition.Y);
            }

            return new DrawData(texture, new Vector2(drawX, drawY - 65) + Offset, frame, Color * ((255 - alpha) / 255f), 0, origin, scale, SpriteEffects.None, 0);
        }

        public void FindColor()
        {
            Color = Lighting.GetColor((int)(Player.position.X / 16f), (int)(Player.position.Y / 16f), Color.White);
        }

    }
}
