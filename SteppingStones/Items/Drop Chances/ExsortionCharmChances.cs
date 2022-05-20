using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExsortionCharmChances
{
    public class ExsortionCharmChances : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(10) == 0)
            {
                if (npc.type == NPCID.Plantera)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExsortionCharm"));

                }
            }
        }
    }
}