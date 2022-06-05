using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod.Tiles.Crafting;

namespace OniumMod.Items.Weapons
{
	public class Extinction : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Extinction"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A weapon that holds intense power all in a blade.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 284;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 1000000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.crit = 14;
			item.shoot = mod.ProjectileType("ExtinctionProjectile");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ForbiddenSoul", 22);
			recipe.AddIngredient(mod, "HeavenlyBar", 18);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 12);
			recipe.AddIngredient(ItemID.TerraBlade);
			recipe.AddTile(ModContent.TileType<ForbiddenTable>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}