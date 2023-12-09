using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooltipManager : MonoBehaviour
{
    private static tooltipManager current;
    public Tooltip tooltip;

    public void Awake()
    {
        current = this; 
    }

    public static void show(string content, string title = "")
    {
        current.tooltip.setText(content, title);
        current.tooltip.gameObject.SetActive(true); 
    }

    public static void hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}
