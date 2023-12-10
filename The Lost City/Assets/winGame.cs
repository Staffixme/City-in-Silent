using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGame : MonoBehaviour
{
    public winCheck wnch;
    // Start is called before the first frame update
    void Start()
    {
        wnch.isWin = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
