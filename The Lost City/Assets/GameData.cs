using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{
    private BuildingData _buildingData;
    public int _food;
    public int _wood;
    public int _stone;
    public int _population;
    public int _water;
    private PlaceControl _control;

    [SerializeField] public GameObject _buildingTip;

     public TextMeshProUGUI _foodText;
     public TextMeshProUGUI _woodText;
     public TextMeshProUGUI _stoneText;
     public TextMeshProUGUI _populationText;
    public TextMeshProUGUI _waterText;

    public GameObject canvas;
    bool isHiden = false;
     

    private void Start()
    {
        
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F3))
        {
            if(isHiden)
            {
                canvas.SetActive(true);
                isHiden = false;
            }
            else
            {
                canvas.SetActive(false);
                isHiden = true;
            }
            
        }
        _foodText.text = _food.ToString();
        _woodText.text = _wood.ToString();
        _stoneText.text = _stone.ToString();
        _populationText.text = _population.ToString();
        _waterText.text = _water.ToString();
        //_buildingData.resources += onResourcesTaken;
        
        
    }

    void hideTip()
    {
        _buildingTip.SetActive(false);
    }
 
}
