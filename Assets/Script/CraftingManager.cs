using UnityEngine;
using System.Collections.Generic;

public class CraftingManager : MonoBehaviour
{
    public static CraftingManager Instance;

    [System.Serializable]
    public struct CraftingRecipe
    {
        public string recipeKey; // สูตร เช่น "ee1e"
        public ItemData resultSprite; // ภาพผลลัพธ์
    }

    public List<CraftingRecipe> recipes; // สูตรทั้งหมด
    private Dictionary<string, ItemData> recipeDictionary;

    private void Awake()
    {
        
        if (Instance == null) Instance = this;

        // แปลงสูตรเป็น Dictionary
        recipeDictionary = new Dictionary<string, ItemData>();
        foreach (var recipe in recipes)
        {
            recipeDictionary[recipe.recipeKey] = recipe.resultSprite;
        }
    }

    public ItemData GetResultSprite(string key)
    {
        // คืนค่าภาพของสูตร ถ้าไม่พบคืนค่า null
        if (recipeDictionary.ContainsKey(key))
            return recipeDictionary[key];
        return null;
    }
}
