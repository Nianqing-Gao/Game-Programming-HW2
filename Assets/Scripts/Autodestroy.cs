using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    public float delay;
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
