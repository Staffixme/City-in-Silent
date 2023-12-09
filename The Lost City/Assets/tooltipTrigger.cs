using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class tooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [TextArea(4, 4)] public string content;
    public string title;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltipManager.show(content, title);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipManager.hide();
    }

    public void OnMouseEnter()
    {
        tooltipManager.show(content, title);
    }


    public void OnMouseExit()
    {
        tooltipManager.hide();
    }


}
