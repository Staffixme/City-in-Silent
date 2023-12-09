using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodHomeData : BuildingData
{
    public override void Start()
    {
        StartCoroutine(villagers());
        base.Start();
    }
   
    private IEnumerator villagers()
    {
        if(_human != _maxHuman)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            _human++;
            _gameData._population++;
        }
        
        yield return null;
        StartCoroutine(villagers());
    }
}
