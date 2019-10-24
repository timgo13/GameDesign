using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lift : MonoBehaviour
{
    public bool player_on = false;
    public float waitfor = 2;
    private float wait;
    public double height;
    public float speed;

    AudioSource lift_sound;

    public Vector3 StartPos;
    
    // Start is called before the first frame update
    void Start()
    {
        wait = 0;
        lift_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < height && player_on){
            if(wait >= waitfor){
                Vector3 x = new Vector3(0,speed * Time.deltaTime,0);
                transform.position = transform.position + x;
            }
            else{
                wait = wait +(1.0f * Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player")){
            player_on = true;
            lift_sound.Play();
        }
    }

    public void ToStart()
    {
        transform.position = StartPos;
        player_on = false;
        wait = 0;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitfor);
    }



    
}
