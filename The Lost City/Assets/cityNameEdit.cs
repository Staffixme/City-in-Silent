using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cityNameEdit : MonoBehaviour
{
    public TMP_InputField cityNameInputField;
    public void onEdit()
    {
        GameData._cityName = cityNameInputField.text;
    }
}
