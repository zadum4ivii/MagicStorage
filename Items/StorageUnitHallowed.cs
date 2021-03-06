using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items
{
	public class StorageUnitHallowed : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Storage Unit");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 4;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.createTile = mod.TileType("StorageUnit");
			item.placeStyle = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StorageUnitHellstone"));
			recipe.AddIngredient(mod.ItemType("UpgradeHallowed"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}