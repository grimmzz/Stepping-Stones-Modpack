using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class PlatinumCrossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Platinum Crossbow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A Lot Faster, a Lot Stronger, and a Lot Better!'");
		}

		public override void SetDefaults() 
		{
			item.damage = 19;
			item.melee = false;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 18);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}