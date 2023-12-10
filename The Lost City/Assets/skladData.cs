using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skladData : BuildingData
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
        if ((_Food <= _gameData._food) && (_wood <= _gameData._wood) && (_water <= _gameData._water))
        {
            _gameData._food -= _neededFood;
            _gameData._wood -= _neededWood;
            _gameData._stone += _neededStone;
            _gameData._water -= _neededWater;
        }
            

        StartCoroutine(RequestingResources());

        //тут реализуй механику того, что здание запрашивает еду и другие ресурсы
    }
}
