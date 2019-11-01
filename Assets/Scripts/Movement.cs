using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;


    public float speed;
    public float boost_speed;
    public int RespawnHeight;
    // Start is called before the first frame update
    public UnityEvent Reset;
    private Vector3 RespawnPos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        RespawnPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= RespawnHeight){
            transform.position = RespawnPos;
            Reset.Invoke();

        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 force =  new Vector3(horizontal, 0, vertical);

        rb.AddForce(force * speed);
    }

    public void Boost()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 force =  new Vector3(horizontal, 0, vertical);

        rb.AddForce(force * speed * boost_speed);
    }
    public void Die()
    {
        Reset.Invoke();
        transform.position = RespawnPos;

    }
}
