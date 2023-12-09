using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    [SerializeField] GameObject loadingPanel;
    public void onSceneSwitched(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void onPlayPreeesed()
    {
        StartCoroutine(loadingscreen());
        
    }
    public void onEXit()
    {
        Application.Quit();
    }

    public IEnumerator loadingscreen()
    {
        loadingPanel.SetActive(true);
        yield  return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
        yield return null;
    }


}
