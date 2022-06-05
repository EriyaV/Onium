using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod.Tiles.Crafting;

namespace OniumMod.Items.Accessories.Enhancements
{
		public class UltimateStar : ModItem
		{
			public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("Ultimate Star"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
				Tooltip.SetDefault("The ancient enhancement fully connected, giving the power of legends." +
					"\nDramatically increases movement speed." +
					"\nAll damage is greatly increased." +
					"\nGreatly increased melee speed." +
					"\nBlock placement speed is increased." +
					"\nWall placement speed is increased.");
			}

			public override void SetDefaults()
			{
				item.width = 20;
				item.height = 20;
				item.value = 90000;
				item.rare = ItemRarityID.Red;
				item.accessory = true;
			}

			public override void UpdateAccessory(Player player, bool hideVisual)
			{
				player.meleeSpeed += 0.3f;
				player.moveSpeed += 3.7f;
				player.accRunSpeed += 1.9f;
				player.allDamageMult += 0.4f;
				player.wallSpeed += 1.5f;
				player.tileSpeed += 0.8f;
		}


		public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "AttackEnhancement");
				recipe.AddIngredient(mod, "BuildEnhancement");
				recipe.AddIngredient(mod, "SpeedEnhancement");
				recipe.AddIngredient(mod, "StrengthEnhancement");
				recipe.AddIngredient(mod, "ForbiddenSoul", 4);
				recipe.AddIngredient(ItemID.GoldBar, 35);
				recipe.AddIngredient(ItemID.FragmentSolar, 1);
				recipe.AddIngredient(ItemID.FragmentNebula, 1);
				recipe.AddIngredient(ItemID.FragmentVortex, 1);
				recipe.AddIngredient(ItemID.FragmentStardust, 1);
				recipe.AddIngredient(ItemID.DestroyerEmblem, 1);
				recipe.AddTile(ModContent.TileType<ForbiddenTable>());
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
}
