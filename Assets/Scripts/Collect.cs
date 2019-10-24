using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Collect : MonoBehaviour
{
    private int count;
    public Text countText;
    public UnityEvent PickUp;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            PickUp.Invoke();
        }
    }

    void SetCountText() {
        countText.text = "Count: " + count.ToString();
    }
}
