using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class FragmentEndDrag : MonoBehaviour, IDropHandler
{
    public GameObject parent;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            var frag = eventData.pointerDrag;
            if (GetComponent<TileItem>().id == frag.GetComponent<TileFragment>().tileItem.id)
            {
                GetComponent<Image>().sprite = frag.GetComponent<Image>().sprite;
                Color c = new Color(1f, 1f, 1f, 1f);
                GetComponent<Image>().color = c;
                Destroy(frag.gameObject);
            }
        }
    }
}
