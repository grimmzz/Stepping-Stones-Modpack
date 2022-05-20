using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class SawedOffMusket : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Sawed-Off Musket"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'You either love it or hate it.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 19;
			item.melee = false;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.AddIngredient(ItemID.Wood, 7);
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}