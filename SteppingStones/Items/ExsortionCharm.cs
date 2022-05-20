using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SteppingStones.Items
{
    public class ExsortionCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Vastly increases life regeneration and all damage");
        }

        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 128;
            item.lifeRegen = 10;
            item.maxStack = 1;
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamageMult += 0.3f;
            player.magicDamageMult += 0.3f;
            player.meleeDamageMult += 0.3f;
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