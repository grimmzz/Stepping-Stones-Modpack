using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class HandBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Hidden Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'SLICE N' DICE'.");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.crit = 1;
			item.width = 40;
			item.height = 40;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 10000;
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