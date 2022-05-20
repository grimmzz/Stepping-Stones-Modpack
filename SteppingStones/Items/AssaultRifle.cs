using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SteppingStones.Items
{
    public class AssaultRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Bomb has been planted'");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.melee = false;
            item.crit = 9;
            item.ranged = true;
            item.noMelee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 60f;
            item.useAmmo = AmmoID.Bullet;
            item.autoReuse = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.ammoCost80 = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AnkhCharm, 1);
            recipe.AddIngredient(ItemID.DemonHeart, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}