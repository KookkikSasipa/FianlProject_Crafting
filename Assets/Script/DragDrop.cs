using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private Canvas canvas;
    
    public bool isOriginal = true; // ระบุว่าเป็นไอเทมต้นฉบับหรือไม่

    public ItemData MyitemData;


    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 originalPosition;
    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalPosition = rectTransform.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        DragShow.instan.ShowImage(eventData,MyitemData);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isOriginal) return; // ห้ามลากไอเท็มต้นฉบับ

        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //if (isOriginal) return; // ห้ามลากไอเท็มต้นฉบับ
        DragShow.instan.SetDrang(eventData);
        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (isOriginal) return; // ห้ามลากไอเท็มต้นฉบับ

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

       
    }
    public void OnPointerUp(PointerEventData eventData) {
        DragShow.instan.OnPointerUp(eventData);
        Debug.Log("OnPointerUp");
        Slot slot = eventData.pointerEnter?.GetComponent<Slot>();
        if (slot != null)
        {
            slot.OnDrop(MyitemData);        
        }
    }
}


