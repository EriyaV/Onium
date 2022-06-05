using Terraria.ID;
using Terraria.ModLoader;
using OniumMod;

namespace OniumMod.Items.Ammo
{
	public class ForbiddenBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forbidden Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Bounces off walls");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.knockBack = 2;
			item.value = 50;
			item.rare = ItemRarityID.LightPurple;
			item.consumable = true;
			item.shoot = mod.ProjectileType("ForbiddenBulletProjectile");
			item.ammo = AmmoID.Bullet;
			item.maxStack = 999;
			item.shootSpeed = 9.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 1);
			recipe.AddIngredient(mod, "ForbiddenSoul", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}