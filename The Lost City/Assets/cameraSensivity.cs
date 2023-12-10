using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraSensivity : MonoBehaviour
{
    public Slider sensivity;
    public static float sens;
    public float sensnow;

    private void Start()
    {
        sens = 0.3f;
    }
    public void onChange()
    {
        sensnow = sensivity.value;
        sens = sensnow;
    }


    
}
