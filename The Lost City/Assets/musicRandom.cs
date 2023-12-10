using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class musicRandom : MonoBehaviour
{

    public AudioSource source;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void takeRandom()
    {
        source.clip = clips[Random.Range(0, clips.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        if(!source.isPlaying) 
        { 
            takeRandom();
            source.Play();
        }
    }
}
