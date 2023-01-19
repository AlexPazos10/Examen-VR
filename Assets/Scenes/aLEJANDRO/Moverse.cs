using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    public Transform target;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed*Time.deltaTime;
        transform.position= Vector3.MoveTowards(transform.position,target.position,step);
    }
}
