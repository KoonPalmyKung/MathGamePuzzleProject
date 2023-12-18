using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;



public class Draganddropitem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    public Text text;
    [HideInInspector] public Transform parentAfterDrag;
    //private bool hasBeenDragged = true;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        text.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        /*if (eventData.pointerEnter.tag.ToString() == "Inv")
        {
            hasBeenDragged = false;
            transform.SetParent(parentAfterDrag);
        }*/
        /*if (hasBeenDragged)
        {*/
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
            text.raycastTarget = true;
        //}
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
