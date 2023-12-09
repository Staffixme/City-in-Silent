using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestHomeData : BuildingData
{
    // Start is called before the first frame update
    public override void Start()
    {
        StartCoroutine(RequestingResources());
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override IEnumerator RequestingResources()
    {
        yield return new WaitForSeconds(_requestTime);
        _gameData._food -= _neededFood;
        _gameData._wood += _neededWood;
        
        StartCoroutine(RequestingResources());

        //тут реализуй механику того, что здание запрашивает еду и другие ресурсы
    }
}
