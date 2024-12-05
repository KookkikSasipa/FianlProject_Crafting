using NUnit.Framework.Interfaces;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CraftingGrid : MonoBehaviour
{
    public Slot[] slots; // อาเรย์ Slot (4 ช่อง)
    public Slot resultSlot; // ช่องแสดงผลลัพธ์

    public void Start()
    {
        UpdateGrid();
        for (int i = 0; i < slots.Length; i++) {
            slots[i].craftingGrid = this;
        }
    }

    public void UpdateGrid()
    {
        // รวมข้อมูลจาก Slot เป็นสูตร
        string recipeKey = "";
        foreach (var slot in slots)
        {
            recipeKey += slot.currentItemKey;
        }

        // ตรวจสอบสูตร
        ItemData result = CraftingManager.Instance.GetResultSprite(recipeKey);
        if (result != null)
        {
            resultSlot.image.sprite = result.itemSprite; // เปลี่ยนภาพผลลัพธ์
            resultSlot.MyitemData = result; // ทำให้มองเห็น
        }
       
        else if(recipeKey == "eeee")
        {
            resultSlot.ClearItem();
        }

        else
        {
            resultSlot.ClearItem();
        }
    }

}
