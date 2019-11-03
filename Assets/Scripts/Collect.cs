using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Collect : MonoBehaviour
{

    public UnityEvent PickUp;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
            PickUp.Invoke();
        }
    }

    
}
