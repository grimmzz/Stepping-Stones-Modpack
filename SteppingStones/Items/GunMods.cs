using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SteppingStones.Items
{
    public class GunMods : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases ranged damage.");
        }

        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 128;
            item.maxStack = 1;
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamage += 0.3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TacticalShotgun, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}