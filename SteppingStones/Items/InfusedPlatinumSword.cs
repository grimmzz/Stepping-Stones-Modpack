using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class InfusedPlatinumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Infused Platinum Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Flowing with the charges of metals and stars'.");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.crit = 1;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = 126;
			item.shootSpeed = 15f;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<InfusedPlatinumBar>(), 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}