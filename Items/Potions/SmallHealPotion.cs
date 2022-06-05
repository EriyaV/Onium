using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod;

namespace OniumMod.Items.Potions
{
	public class SmallHealPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Small Heal Potion"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("First ever potion.");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.value = 25000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
			item.autoReuse = true;
			item.material = true;
			item.potion = true;
			item.healLife = 75;
			item.maxStack = 30;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ItemID.Mushroom, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
