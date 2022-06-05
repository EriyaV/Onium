using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod.Tiles.Crafting;

namespace OniumMod.Items.Weapons
{
	public class Faith : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Faith"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The endgame.");
		}

		public override void SetDefaults()
		{
			item.damage = 262;
			item.melee = true;
			item.scale = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 1000000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.crit = 14;
			item.shoot = mod.ProjectileType("FaithShootProjectile");
			item.shootSpeed = 30f;
			item.autoReuse = true;
			item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ForbiddenSoul", 22);
			recipe.AddIngredient(mod, "HeavenlyBar", 15);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 12);
			recipe.AddIngredient(ItemID.DayBreak);
			recipe.AddTile(ModContent.TileType<ForbiddenTable>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}