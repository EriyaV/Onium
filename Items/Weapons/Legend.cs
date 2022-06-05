using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod.Tiles.Crafting;

namespace OniumMod.Items.Weapons
{
	public class Legend : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Legend"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires two arrows." +
				"\n'Ancient materials forged together creating this elite bow.'");
		}


		public override void SetDefaults()
		{
			item.damage = 272;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 1;
			item.value = 3000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 17.5f;
			item.crit = 17;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ForbiddenSoul", 18);
			recipe.AddIngredient(mod, "HeavenlyBar", 15);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 12);
			recipe.AddTile(ModContent.TileType<ForbiddenTable>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			for (var i = 0; i < 1; i++) {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.ToRadians(10 * i));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(6, 0);
			return offset;
		}

	}
}