using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Death : MonoBehaviour
{

    [SerializeField] UnityEvent triggerEvent;
    [SerializeField] AudioClip triggerClip;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerEvent.Invoke();
            AudioSource.PlayClipAtPoint(triggerClip, Camera.main.transform.position);
            
        }
    }
}
