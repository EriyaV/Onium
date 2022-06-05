using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace OniumMod
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class ExamplePlayer : ModPlayer
	{
		public bool infinity;
		public bool nonStopParty;
		public bool UpdateValue;
		public bool ZoneExample;
		public int reviveTime = 7;
		internal bool examplePersonGiftReceived;

		public override void ResetEffects()
		{
			infinity = false;
		}
		public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
		{
			player.lifeRegen = 0;
		}
	}
}