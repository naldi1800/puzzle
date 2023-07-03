using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileFragment : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    public TileItem tileItem;
    public Canvas canvas;

    private RectTransform itemTransform;
    private CanvasGroup canvasGroup;
    private void Awake()
    {
        tileItem = gameObject.AddComponent<TileItem>();
        itemTransform = GetComponent<RectTransform>();
        canvasGroup = transform.gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = .6f;
        
        AudioManager.Instance.playSFX("ItemSelect");
    }

    public void OnDrag(PointerEventData eventData)
    {
        itemTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnPointerDown(PointerEventData eventData) { }
    public void OnDrop(PointerEventData eventData) { }
}
