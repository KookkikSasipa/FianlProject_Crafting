using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
   /* public Slot[,] craftingGrid = new Slot[2, 2]; // ตาราง 2x2
    public Slot resultSlot; // ช่องผลลัพธ์

    

    [System.Serializable]
    public class Recipe
    {
        public ItemData[,] pattern = new ItemData[2, 2]; // รูปแบบ 2x2 ของสูตร
        public ItemData result; // ผลลัพธ์ที่ได้จากสูตรนี้
    }

    public List<Recipe> recipes = new List<Recipe>(); // เก็บสูตรทั้งหมด

    // ฟังก์ชันตรวจสอบสูตรใน Crafting Grid
    public void CheckCraftingGrid()
    {
        foreach (Recipe recipe in recipes)
        {
            if (MatchRecipe(recipe))
            {
                // ถ้าสูตรตรงกัน ให้ตั้งค่าไอเท็มในช่องผลลัพธ์
                resultSlot.SetItem(recipe.result);
                return;
            }
        }

        // ถ้าไม่ตรงกับสูตรใดเลย ให้เคลียร์ช่องผลลัพธ์
        resultSlot.ClearItem();
    }

    private bool MatchRecipe(Recipe recipe)
    {
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                ItemData slotItem = craftingGrid[x, y].currentItemData;
                ItemData recipeItem = recipe.pattern[x, y];

                // ถ้าช่องในสูตรเป็น null ให้ข้าม
                if (recipeItem == null) continue;

                // ถ้าช่องในสูตรไม่ตรงกับไอเท็มใน Grid ให้ล้มเหลว
                if (slotItem != recipeItem) return false;
            }
        }
        return true;
    }


    // ฟังก์ชันเรียกใช้เมื่อกดปุ่ม Craft
    public void CraftItem()
    {
        if (resultSlot.currentItemData != null)
        {
            // ลบวัตถุดิบทั้งหมดใน Grid
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    craftingGrid[x, y].ClearItem();
                }
            }

            // สร้างไอเท็มใน Result Slot (ล็อกให้ผู้เล่นลากออก)
            resultSlot.LockItem();
        }
    }

  */

}
