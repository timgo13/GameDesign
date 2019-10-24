using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Schlüssel_Script : MonoBehaviour
{
    public UnityEvent Picked;
    [SerializeField] AudioClip triggerClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        
            this.gameObject.SetActive(false);
            Picked.Invoke();
            AudioSource.PlayClipAtPoint(triggerClip, Camera.main.transform.position);
            
    }
}

