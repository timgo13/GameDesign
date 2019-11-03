using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //[SerializeField] AudioClip triggerClip;
    public UnityEvent nextLevel;
    AudioSource change_sound;
    void Start()
    {
        change_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        change_sound.Play();
        nextLevel.Invoke();
        //AudioSource.PlayClipAtPoint(triggerClip, Camera.main.transform.position);
       
    }
}
