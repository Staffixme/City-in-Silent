using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlaceControl : MonoBehaviour
{
    RaycastHit hit;
    Vector3 movement;
    public GameObject prefab;
    public GameData _gameData;
    BoxCollider trigger;
    bool _canBuild = true;
    public BuildingData _buildingData;
    


    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<BoxCollider>();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {
            transform.position = hit.point;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Building")
        {
            _canBuild = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Building")
        {
            _canBuild = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {
            transform.position = hit.point;
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,0.2f,0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -0.2f, 0);
        }
        if (Input.GetMouseButton(0))
        {
            if (_canBuild == true)
            {
                
               
                    Instantiate(prefab, transform.position, transform.rotation);
                    Destroy(gameObject);
                
                
            }
            
            
        }

            if (Input.GetMouseButton(1)) {
            Destroy(gameObject);
            
        }
    } 
    
}
