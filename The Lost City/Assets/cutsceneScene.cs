using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutsceneScene : MonoBehaviour
{
    public int time;
    public int sceneNum;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cutscene());
    }
    public void onSkip()
    {
        SceneManager.LoadScene(sceneNum);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator cutscene()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneNum);
        yield return null;
    }
}
