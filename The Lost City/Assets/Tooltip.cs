using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI titleField;
    public TextMeshProUGUI contentField;
    public LayoutElement layoutElem;
    public int chrWrapLimit;

    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void setText(string content, string title = "") 
    {
        if (string.IsNullOrEmpty(title))
        {
            titleField.gameObject.SetActive(false);
        }
        else
        {
            titleField.gameObject.SetActive(true);
            titleField.text = title;
        }

        contentField.text = content;
    }

    private void Update()
    {
        int titleLenght = titleField.text.Length;
        int contentLenght = contentField.text.Length;

        layoutElem.enabled = (titleLenght > chrWrapLimit || contentLenght > chrWrapLimit) ? true : false;
        //Vector2 position = Input.mousePosition;


        //float pivotX = position.x / Screen.width;
        //float pivotY = position.y / Screen.height;

        //rectTransform.pivot = new Vector2(pivotX, pivotY);
        //transform.position = position;
        Vector2 position = Input.mousePosition;
        float x = position.x / Screen.width;
        float y = position.y / Screen.height;
        if (x <= y && x <= 1 - y) //left
            rectTransform.pivot = new Vector2(-0.15f, y);
        else if (x >= y && x <= 1 - y) //bottom
            rectTransform.pivot = new Vector2(x, -0.1f);
        else if (x >= y && x >= 1 - y) //right
            rectTransform.pivot = new Vector2(1.1f, y);
        else if (x <= y && x >= 1 - y) //top
            rectTransform.pivot = new Vector2(x, 1.3f);
        transform.position = position;
    }

   

    


}
