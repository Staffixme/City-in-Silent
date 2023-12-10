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
    public static string _cityName;
    private PlaceControl _control;
    public GameObject zabor, butka1, butka2, zdanye, battery, trash, signal_station, finalbutton;

    

     public TextMeshProUGUI _foodText;
     public TextMeshProUGUI _woodText;
     public TextMeshProUGUI _stoneText;
     public TextMeshProUGUI _populationText;
     public TextMeshProUGUI _waterText;
    public TextMeshProUGUI _cityText;
     [SerializeField] GameObject pausepanel; 

    public GameObject canvas;
    bool isHiden = false;
     
    public void resume()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    private void Start()
    {
        _cityText.text = _cityName.ToString();
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape)) 
        { 
            Time.timeScale = 0f;
            pausepanel.SetActive(true);
        }
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
        
        if(_population == 10)
        {
            zabor.SetActive(true);
        }
        if(_population == 50) 
        { 
            butka1.SetActive(true);
        }
        if(_population == 100)
        {
            butka2.SetActive(true);
        }
        if (_population == 200)
        {
            zdanye.SetActive(true);
        }
        if(_population == 350)
        {
            zdanye.SetActive(true);
        }
        if(_population == 500)
        {
            battery.SetActive(true);
        }
        if(_population == 1000)
        {
            trash.SetActive(true);
        }
        if( _population >= 2500)
        {
            signal_station.SetActive(true);
            finalbutton.SetActive(true);
        }
    }

    
 
}
