﻿using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Sounds
{
	public class ScreenChange : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan)
		{
			SoundEffectInstance instance = Sound.Value.CreateInstance();
			instance.Play();
			soundInstance.Volume = volume * 1f;
			soundInstance.Pan = pan;
			return soundInstance;
		}
	}
}