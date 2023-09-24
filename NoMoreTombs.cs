using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoMoreTombs
{
    //change Mod interface implementation to ModSystem.
    //https://forums.terraria.org/index.php?threads/how-to-fix-warning-cs0672.114350/ 
    public class NoMoreTombs : ModSystem
	{
		public override void Load()
		{
			TombDetours.ApplyDetours();
		}
		public override void AddRecipes()
		{
            Recipe gravestone = Recipe.Create(ItemID.Gravestone);
            gravestone.AddIngredient(ItemID.StoneBlock, 20);
            gravestone.AddTile(TileID.WorkBenches);
            gravestone.Register();

            Recipe tombstone = Recipe.Create(ItemID.Tombstone);
            tombstone.AddIngredient(ItemID.StoneBlock, 20);
            tombstone.AddTile(TileID.WorkBenches);
            tombstone.Register();

            Recipe headstone = Recipe.Create(ItemID.Headstone);
            headstone.AddIngredient(ItemID.StoneBlock, 20);
            headstone.AddTile(TileID.WorkBenches);
            headstone.Register();

            Recipe crossgrave = Recipe.Create(ItemID.CrossGraveMarker);
            crossgrave.AddIngredient(ItemID.StoneBlock, 10);
            crossgrave.AddIngredient(ItemID.Wood, 10);
            crossgrave.AddTile(TileID.WorkBenches);
            crossgrave.Register();

            Recipe gravemarker = Recipe.Create(ItemID.GraveMarker);
            gravemarker.AddIngredient(ItemID.StoneBlock, 10);
            gravemarker.AddIngredient(ItemID.Wood, 10);
            gravemarker.AddTile(TileID.WorkBenches);
            gravemarker.Register();

            Recipe obelisk = Recipe.Create(ItemID.Obelisk);
            obelisk.AddIngredient(ItemID.Obsidian, 20);
            obelisk.AddTile(TileID.WorkBenches);
            obelisk.Register();
        }
	}
}