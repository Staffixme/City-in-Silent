using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colodec : BuildingData
{
    // Start is called before the first frame update
    public override void Start()
    {
        StartCoroutine(RequestingResources());
        base.Start();
    }
    public override IEnumerator RequestingResources()
    {
        yield return new WaitForSeconds(_requestTime);
        if ((_Food <= _gameData._food) && (_wood <= _gameData._wood) && (_stone <= _gameData._stone))
        {
            _gameData._stone -= _neededStone;
            _gameData._water += _neededWater;
        }
            

        StartCoroutine(RequestingResources());

        //��� �������� �������� ����, ��� ������ ����������� ��� � ������ �������
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
