using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SteppingStones.Items
{
    public class EmblemOfThoth : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grants immunity to most de-buffs\ngreatly increases life regeneration and\nincreases all damage.");
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
            player.noKnockback = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.Webbed] = true;
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AnkhCharm, 1);
            recipe.AddIngredient(ModContent.ItemType<ExsortionCharm>(), 1);
            recipe.AddIngredient(ItemID.AnkhShield, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}