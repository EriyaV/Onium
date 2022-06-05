using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod;

namespace OniumMod.Items.Accessories.Enhancements
{
	public class SpeedEnhancement : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Speed Enhancement"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("One of the ancient enhancements that have been split for many years, waiting to be connected." +
				"\nGreatly Increases movement speed.");
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
			player.moveSpeed += 0.5f;
			player.accRunSpeed += 0.7f;
		}
	}
}
