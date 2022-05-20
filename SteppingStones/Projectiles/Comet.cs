using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace SteppingStones.Projectiles
{
    public class Comet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.penetrate = 6;                       //this is the projectile penetration
            projectile.hostile = false;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
            projectile.timeLeft = 300;
            projectile.aiStyle = 1;
        }

       public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }

        //public float rotate = 20;
        public override void AI()
        {
            //this is projectile dust
            //int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width - 3, projectile.height - 3, 40, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 10, Color.Purple, 1f);
            //Main.dust[DustID2].noGravity = true;
            //this make that the projectile faces the right way 
            //rotate -= 0.008f;
            //projectile.rotation += rotate;
            projectile.localAI[0] += 1f;
            //projectile.light = .04f;
            //projectile.alpha = (int)projectile.localAI[0] * 2;
        }
    }
}