using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakRuin : MonoBehaviour
{
    RaycastHit hit;
    public GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    }
    public void onbreak()
    {
        Destroy(gameObject);
                    gameData._stone += Random.Range(1, 3);
                    gameData._food += Random.Range(1, 3);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            


        }
    }
}
