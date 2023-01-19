using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[]cubos;
    public Transform [] points;
    public float beat = (60/105)*2;
    private float timer;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(timer>beat)
        {
            GameObject cubo = Instantiate(cubos[Random.Range(0,2)],points[Random.Range(0,4)]);
            cubo.transform.localPosition=Vector3.zero;
            cubo.transform.Rotate(transform.forward,90* Random.Range(0,4));
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
    
}
