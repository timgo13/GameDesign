using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float hight;
    private Rigidbody rb;
    private float cooldown = 0f;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
     void FixedUpdate()
     {
 
         if (Input.GetKey(KeyCode.Space) && Time.time > cooldown )
         {
            rb.AddForce(new Vector3(0,1f,0) * hight, ForceMode.Impulse);
            cooldown = Time.time + 0.7f;
         }
     }
}
