using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class FlameRaiper : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Flame Raiper"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'SLICE THE FIRE!'");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 18;
			item.melee = true;
			item.crit = 1;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = ProjectileID.Flames;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 8f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(ItemID.Katana, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}