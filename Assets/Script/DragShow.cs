using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragShow : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public static DragShow instan;
    public Image image;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    
   
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        image = GetComponent<Image>();
        if (instan == null)
        {
            instan = this;
        }
        else if(instan != this) { 
            Destroy(instan.gameObject);
        }
    }
 
    public void ShowImage(PointerEventData eventData,ItemData itemData) {
        image.enabled = true;
        image.sprite = itemData.itemSprite;
        rectTransform.position = eventData.position;
        Debug.Log(eventData.position);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("The mouse click was released");
        image.enabled = false;
    }
    public void SetDrang(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }
}
