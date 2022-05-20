using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class grimsKnivesWeapon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("grim's Knives"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Some say grim is still looking for them.'");
		}


		public override void SetDefaults()
		{
			item.damage = 140;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.crit = 1;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 3000;
			item.UseSound = SoundID.Item39;
			item.noUseGraphic = true;
			item.rare = 8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GrimsKnives");
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VampireKnives, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			recipe.AddIngredient(ItemID.ShroomiteBar, 15);
			recipe.AddIngredient(ModContent.ItemType<GrimsaliteBar>(), 12);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 offset = new Vector2(speedX * 0, speedY * 0);
			position += offset;
			for (var i = 0; i < 4; i++)
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