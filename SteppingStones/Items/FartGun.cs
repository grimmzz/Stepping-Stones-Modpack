using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class FartGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Fart Gun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Sparkles not included.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 89;
			item.melee = false;
			item.crit = 9;
			item.ranged = true;
			item.noMelee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item16;
			item.shoot = ProjectileID.SporeCloud;
			item.shootSpeed = 30f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 15);
			recipe.AddIngredient(ItemID.LeafBlower, 1);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}