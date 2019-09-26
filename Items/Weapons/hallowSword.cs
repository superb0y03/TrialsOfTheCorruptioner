using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrialsOfTheCorruptioner.Items.Weapons
{
	public class hallowSword : ModItem
	{

		public override void SetDefaults()
		{

			item.damage = 60;
			item.melee = true;
			item.width = 32;
			item.height = 17;

			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("pinkghost");
			item.shootSpeed = 3f;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Light Purge");
      Tooltip.SetDefault("Shoots A friendly hallowed ghost at your enemies");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 30);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
