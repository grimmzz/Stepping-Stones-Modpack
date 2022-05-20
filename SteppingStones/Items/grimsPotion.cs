using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;


namespace SteppingStones.Items
{
	public class grimsPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("grim's Potion"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Heals 150 HP\nHeals 100 MP\n'Now your taking my blood!?'.");
		}

		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.value = 10000;
			item.consumable = true;
			item.useTurn = true;
			item.potion = true;
			item.healLife = 150;
			item.healMana = 100;
			item.useTime = 9;
			item.useAnimation = 9;
			item.maxStack = 30;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public static void UseItem(Player player, int playerID)
		{

			player.AddBuff(3, 600, true);
			player.AddBuff(5, 600, true);
			player.AddBuff(17, 600, true);

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}