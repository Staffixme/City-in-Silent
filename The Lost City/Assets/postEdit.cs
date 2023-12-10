using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class postEdit : MonoBehaviour
{
    public PostProcessVolume postVol;
    // Start is called before the first frame update
    void Start()
    {
        postVol = GetComponent<PostProcessVolume>();
    }
    public void onEnb()
    {
        postVol.enabled = true;
    }
    public void onDsb()
    {
        postVol.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
