using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class wheel : BuildingData
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.zero, 20 * Time.deltaTime);
    }
}
