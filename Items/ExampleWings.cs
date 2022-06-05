using OniumMod.Tiles;
using OniumMod.Items.Materials;
using OniumMod.Tiles.Crafting;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OniumMod.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class ExampleWings : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return !ModContent.GetInstance<ExampleConfigServer>().DisableExampleWings;
		}

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded wing.");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 280;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) {
			speed = 14f;
			acceleration *= 4.5f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ForbiddenSoul>(), 60);
			recipe.AddTile(ModContent.TileType<ForbiddenTable>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}