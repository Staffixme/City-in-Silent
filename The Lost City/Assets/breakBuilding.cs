using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakBuilding : MonoBehaviour
{

    bool breakMode = false;
    RaycastHit hit;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {
            transform.position = hit.point;
        }

        if (Input.GetMouseButton(0))
        {
            
            
            Destroy(gameObject);
        }
    }

    public void activateBreak()
    {
        if (breakMode)
        {
            breakMode = false;
        }
        else
        {
            breakMode = true;
        }
    }
}
