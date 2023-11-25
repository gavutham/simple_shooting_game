using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int speed = 5;
    // Start is called before the first frame update
    private bool isUp = false;
    private int steps = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(isUp){
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            steps+=1;
            if(steps > 10) isUp = false;
        }

        else{
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            steps-=1;
            if(steps < 0) isUp = true;
        }
        
    }
}
