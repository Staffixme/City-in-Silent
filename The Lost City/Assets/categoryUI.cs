using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class categoryUI : MonoBehaviour
{
    public GameObject panel;
    bool isEnabled = false;

    public void onClick()
    {
        if (isEnabled)
        {
            panel.SetActive(false);
            isEnabled = false;
        }
        else
        {
            panel.SetActive(true);
            isEnabled = true;
        }
            
    }
}