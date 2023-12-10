using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class qualty : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public void checkdropdown()
    {
        QualitySettings.SetQualityLevel(dropdown.value, true);//Изменяем уровен графики
    }
}