using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrialsOfTheCorruptioner.Projectiles
{

    public class pinkghost : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Spirit");
		}
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.friendly = true;      //make that the projectile will not damage you
			projectile.hostile = false;
            projectile.tileCollide = true;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = 1;      //how many npc will penetrate
            projectile.timeLeft = 200;   //how many time this projectile has before disepire
            projectile.light = 0.5f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
			Main.projFrames[projectile.type] = 3;
			
			
        }
        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;  
			projectile.velocity.Y += projectile.ai[0];
			projectile.netUpdate = true;
			if (projectile.localAI[0] == 0f)
            {
                projectile.localAI[0] = 1f;
            }
			projectile.frameCounter++;

			if (projectile.frameCounter > 16)
			{
			projectile.frame++;
			projectile.frameCounter = 0;
			}
			if (projectile.frame > 1)
			{
			projectile.frame = 0;
			}
			if (projectile.frame > 1)
			{
			projectile.frame = 0;
			}

            
			}
		
		
		public override void Kill(int timeLeft)
		{
			for (int i = 2; i < 31; i++)
			{
				Color color = new Color(94, 229, 163);
				float x = projectile.oldVelocity.X * (30f / i);
				float y = projectile.oldVelocity.Y * (30f / i);

			}
		}
    }
}