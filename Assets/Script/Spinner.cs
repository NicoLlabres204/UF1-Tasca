using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotation_speed;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate(){
        transform.Rotate(new Vector3(0,0,rotation_speed));
    }
}
