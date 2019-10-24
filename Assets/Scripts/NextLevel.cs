using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //[SerializeField] AudioClip triggerClip;
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
        SceneManager.LoadScene(1);
        //AudioSource.PlayClipAtPoint(triggerClip, Camera.main.transform.position);
       
    }
}
