using Terraria;
using Terraria.ModLoader;

namespace OniumMod.Buffs
{
	public class SuperIronSkinBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Super Ironskin Buff");
			Description.SetDefault("Grants +16 defense.");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 16; //Grant a +4 defense boost to the player while the buff is active.
		}
	}
}