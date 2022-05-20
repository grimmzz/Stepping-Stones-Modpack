using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class GrimsaliteBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Grimsalite Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Why do i have my own bar?'.");
		}

		public override void SetDefaults() 
		{
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useStyle = 0;
			item.value = 10000;
			item.maxStack = 99;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddIngredient(ItemID.ShroomiteBar, 1);
			recipe.AddIngredient(ItemID.SpectreBar, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}