using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public string requiredItemType; // ประเภทไอเท็มที่ต้องการ เช่น "Metal"
    public Image image;
    public ItemData MyitemData;

    public int slotIndex; // ตำแหน่ง Slot (0-3 สำหรับ 2x2)
    public string currentItemKey = "e"; // เก็บคีย์ไอเท็ม ("e" = ว่าง)
    public CraftingGrid craftingGrid; // อ้างอิงระบบตารางคราฟ

    public void OnPointerDown(PointerEventData eventData)
    {
        if (MyitemData != null) {
            DragShow.instan.ShowImage(eventData, MyitemData);
        }
    }

    public void ClearItem()
    {
        MyitemData = null;
        image.sprite = null;
        currentItemKey = "e";
        ; // แจ้งตารางให้ตรวจสอบสูตร
    }

    public void OnDrop(ItemData i)
    {
        Debug.Log(" OnDrop slot");
        MyitemData = i;
        image.sprite = MyitemData.itemSprite;
        currentItemKey = MyitemData.itemKey;
        craftingGrid.UpdateGrid();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (MyitemData != null) {
            DragShow.instan.SetDrang(eventData);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        DragShow.instan.OnPointerUp(eventData);

        Slot slot = eventData.pointerEnter?.GetComponent<Slot>();
        if (slot != null)
        {
            slot.OnDrop(MyitemData);
        }
        ClearItem();
        craftingGrid.UpdateGrid();
    }
}
