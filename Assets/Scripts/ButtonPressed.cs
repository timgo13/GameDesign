using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;


public class ButtonPressed : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent;
    [SerializeField] AudioClip triggerClip;
    bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(!triggered && other.CompareTag("Player"))
        {
            triggerEvent.Invoke();
            triggered = true;
            AudioSource.PlayClipAtPoint(triggerClip, Camera.main.transform.position);
            ChangeLight();
        }
    }

    private void ChangeLight()
    {
        Light light = GetComponentInChildren<Light>();
        light.color = Color.green;
    }
}
