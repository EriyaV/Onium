using OniumMod.Items;
using OniumMod.Items.Accessories;
using OniumMod.Items.Accessories.Enhancements;
using OniumMod.Items.Placeable;
using OniumMod.Enemies;
using OniumMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OniumMod.Items.Drops
{
	public class PuritySpiritBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Purple;
			item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			player.TryGettingDevArmor();
			int choice = Main.rand.Next(7);
			if (choice == 0) {
				player.QuickSpawnItem(ModContent.ItemType<UltimateStar>());
			}
			else if (choice == 1) {
				player.QuickSpawnItem(ModContent.ItemType<BlessingOfInfinity>());
			}
			if (choice != 1) {
				player.QuickSpawnItem(ModContent.ItemType<ForbiddenSoul>());
			}
			player.QuickSpawnItem(ModContent.ItemType<HeavenlyBar>());
		}

		public override int BossBagNPC => ModContent.NPCType<CyanSlime>();
	}
}