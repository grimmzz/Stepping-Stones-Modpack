using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;


namespace SteppingStones.Items
{
	public class InfusedPlatinumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Infused Platinum Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Flowing with the charges of metals and stars'.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(9, 7));
		}

		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useStyle = 0;
			item.value = 10000;
			item.maxStack = 99;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
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