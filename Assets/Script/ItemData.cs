using UnityEngine;


    [System.Serializable]
    public class ItemData: MonoBehaviour
    {
    public string itemKey; // คีย์ไอเท็ม เช่น "1", "2", หรือ "e
    public string itemType; // ประเภทไอเท็ม เช่น "Wood", "Metal"
    public Sprite itemSprite; // ภาพไอเท็มสำหรับ UI
}

