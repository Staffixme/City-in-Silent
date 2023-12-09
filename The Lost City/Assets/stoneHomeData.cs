using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneHomeData : BuildingData
{
    // Start is called before the first frame update
     public override void Start()
    {
        base.Start();
        StartCoroutine(villagers());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator villagers()
    {
        if (_human != _maxHuman)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            _human++;
            _gameData._population++;
        }

        yield return null;
        StartCoroutine(villagers());
    }
}
