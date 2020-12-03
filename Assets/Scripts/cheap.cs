using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheap : MonoBehaviour
{
    public GameObject player;
    public wander bf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            bf.go = true;
        }
    }
}
