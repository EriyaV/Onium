using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod;

namespace OniumMod.Items.Accessories.Enhancements
{
		public class AttackEnhancement : ModItem
		{
			public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("Attack Enhancement"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
				Tooltip.SetDefault("One of the ancient enhancements that have been split for many years, waiting to be connected." +
					"\nGreatly increases melee speed");
			}

			public override void SetDefaults()
			{
				item.width = 20;
				item.height = 20;
				item.value = 40000;
				item.rare = ItemRarityID.Orange;
				item.accessory = true;
				item.material = true;
		}

			public override void UpdateAccessory(Player player, bool hideVisual)
			{
				player.meleeSpeed += 0.7f;
			}


			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldBar, 35);
				recipe.AddTile(TileID.Furnaces);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
}
