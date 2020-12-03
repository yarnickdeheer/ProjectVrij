using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zinken : MonoBehaviour
{
    public GameObject player;
    public Animator log;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == player)
        {
            log.SetBool("trig", true);
        }
    }
}
