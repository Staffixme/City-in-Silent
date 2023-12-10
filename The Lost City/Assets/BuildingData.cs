using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource)), SelectionBase]
public class BuildingData : MonoBehaviour
{
    [Header("House assets"), Tooltip("В этих полях прокидываем ассеты для дома (например: звуки, партиклы)")]
    [SerializeField] protected AudioClip _creature;
    [SerializeField] protected AudioClip _delete;
    

    [Space(20), Header("Maximum building resources"), Tooltip("Максимальное кол-во ресурсо, которыми может владеть здание")]
    [SerializeField] protected int _maxHuman;
    [SerializeField] protected int _maxWater;
    [SerializeField] protected int _maxFood;

    [Space(20), Header("Necessary resources"), Tooltip("В этих полях указываются ресурсы, которые игрок потратит для постройки здания")]
    [SerializeField] public int _Food;
    [SerializeField] public int _wood;
    [SerializeField] public int _stone;

    [Space(20), Header("Aditional")] 
    [SerializeField, Range(0, 60)] protected float _requestTime = 30;
    [SerializeField, TextArea(4, 4)] protected string _buildingDescription;

    [SerializeField] public int _neededFood;
    [SerializeField] public int _neededWood;
    [SerializeField] public int _neededStone;
    [SerializeField] public int _neededWater;
    protected AudioSource _audioSorce;

    protected int _human;
    protected int _water;
    protected int _food;

    public GameData _gameData;

    public virtual void Start()
    {
        _gameData = FindObjectOfType<GameData>();
        _audioSorce = GetComponent<AudioSource>();
        StartCoroutine(RequestingResources());
        Сonstruction();
    }
    private void Update()
    {
        //breakBuilding.destroy += onDestroy;
    }
    public virtual void onDestroy()
    {
        Destroy(gameObject);
    }
    public virtual void Сonstruction()
    {
        //здесь нужно реаоизовать зачисление ресурсов дома в общие данные игрока
        if((_Food <= _gameData._food) && (_wood <= _gameData._wood) && (_stone <= _gameData._stone))
        {
            _audioSorce.PlayOneShot(_creature);
                    _gameData._food -= _Food;
                    _gameData._wood -= _wood;
                    _gameData._stone -= _stone;
        }
        else
        {
            Destroy(gameObject) ;
        }
        
    }

    public virtual void Destruction()
    {
        //реализовать зачисление части ресурсов в общие данные игрока (пусть будет 10-15% от необходимых ресурсов для строительства)
    }

    
    public virtual IEnumerator RequestingResources()
    {
        yield return new WaitForSeconds(_requestTime);
        if((_Food <= _gameData._food) && (_wood <= _gameData._wood) && (_stone <= _gameData._stone) && (_water <= _gameData._water))
        {
            _gameData._food -= _neededFood;
            _gameData._wood -= _neededWood;
            _gameData._stone -= _neededStone;
            _gameData._water -= _neededWater;
        }
        
        StartCoroutine(RequestingResources());
        
        //тут реализуй механику того, что здание запрашивает еду и другие ресурсы
    }
}
