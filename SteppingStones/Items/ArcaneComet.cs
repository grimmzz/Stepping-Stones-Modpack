using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SteppingStones.Items
{
	public class ArcaneComet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Arcane Comet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A Little Faster, a Little Stronger, and Just a Little Better!'");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 48;
			item.melee = false;
			item.magic = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item88;
			item.shoot = mod.ProjectileType("Comet");
			item.shootSpeed = 30f;
			item.CloneDefaults(ItemID.MeteorStaff);
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int Comet, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 44) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("Comet"), damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
	}
}