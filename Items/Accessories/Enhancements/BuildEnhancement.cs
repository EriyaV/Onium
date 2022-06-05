using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OniumMod;

namespace OniumMod.Items.Accessories.Enhancements
{
	public class BuildEnhancement : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Build Enhancement"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("One of the ancient enhancements that have been split for many years, waiting to be connected." +
				"Increases tile and wall speed.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 40000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.tileSpeed += 0.4f;
			player.wallSpeed += 0.4f;
		}
	}
}
