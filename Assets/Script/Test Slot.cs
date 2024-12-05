using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestSlot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public string requiredItemType; 
    public Image image;
    public ItemData MyitemData;

    public int slotIndex;
    public string currentItemKeys = "e";
    [SerializeField] string Final; 

    public void OnPointerDown(PointerEventData eventData)
    {
        if (MyitemData != null)
        {
            DragShow.instan.ShowImage(eventData, MyitemData);
        }
    }

    public void ClearItem()
    {
        MyitemData = null;
        image.sprite = null;
        currentItemKeys = "e";
    }

    public void OnDrop(ItemData i)
    {
        Debug.Log(" OnDrop slot");
        MyitemData = i;
        image.sprite = MyitemData.itemSprite;
        currentItemKeys = MyitemData.itemKey;
        if (currentItemKeys == Final)
        {
            Debug.Log("KUY");
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (MyitemData != null)
        {
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
    }
}