using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GunModDrop
{
    public class GunModDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(20) == 0)
            {
                if (npc.type == NPCID.SkeletonSniper)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GunMods"));
                }
                if (npc.type == NPCID.BoneLee)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GunMods"));
                }
                if (npc.type == NPCID.TacticalSkeleton)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GunMods"));
                }
            }
        }
    }
}