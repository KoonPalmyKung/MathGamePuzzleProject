using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventoryslot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Draganddropitem draganddropitem = dropped.GetComponent<Draganddropitem>();
            draganddropitem.parentAfterDrag = transform;
        }
    }

}
