using Terraria;
using Terraria.ModLoader;
using System;
using OniumMod.Dusts;

namespace OniumMod.Projectiles
{
	public class FaithShootProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 60;
			projectile.height = 125;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.penetrate = 6;
			projectile.timeLeft = 256;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.light = 1.2f;

		}

		public override void AI()
		{
			if (Main.rand.NextBool(1)) Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<GoldenDust>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);

			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 2.1f / 3;
		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++) {
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<GoldenDust>(), projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
		}

	}
}