using Terraria;
using Terraria.ModLoader;

namespace OniumMod.Dusts
{
	public class GoldenDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 0.2f;
			dust.noGravity = true;
			dust.noLight = false;
			dust.scale = Main.rand.Next(100) * .01f + 0.25f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			if (dust.velocity.Y > -4f)
				dust.velocity.Y -= .05f;
			dust.rotation = 0;
			dust.scale *= 0.99f;
			if (dust.scale < .2f) {
				dust.active = false;
			}
			return false;
		}
	}
}