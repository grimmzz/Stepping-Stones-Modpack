using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class WinterReesesSythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Winter Reese's Sythe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A legendary weapon from a once legendary warrior'");
		}


		public override void SetDefaults()
		{
			item.damage = 124;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 3000;
			item.UseSound = SoundID.Item28;
			item.rare = 7;
			item.autoReuse = true;
			item.shoot = ProjectileID.IceSickle;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DeathSickle, 1);
			recipe.AddIngredient(ItemID.FrostCore, 2);
			recipe.AddIngredient(ItemID.Frostbrand, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 offset = new Vector2(speedX * 5, speedY * 5);
			position += offset;
			for (var i = 0; i < 3; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10 * i));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(4, 0);
			return offset;
		}

	}
}