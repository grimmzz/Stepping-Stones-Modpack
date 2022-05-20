using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class WoodenCrossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Wooden Crossbow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Faster, Stronger, and Just Better!'");
		}

		public override void SetDefaults() 
		{
			item.damage = 9;
			item.melee = false;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 18);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}