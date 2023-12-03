using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueprintManager : MonoBehaviour
{
    public GameObject blueprint;

    public void blueprint_Place() { 
      Instantiate(blueprint); 
    }
}
