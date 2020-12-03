using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Next : MonoBehaviour
{
    public int threshhold = 0;
    public int[] goal;

    public int Q;
    public GameObject BF;
    public wander next;
    

    public lvls[] lvlsystem;
        
    // Start is called before the first frame updatepub
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, BF.transform.position);
        if (threshhold == goal[Q] && dist < 10f)
        {
            Q++;
            threshhold = 0;
            next.go = true;

        }
        
    }
    private void OnTriggerEnter(Collider coll)
    {
       // if (coll.gameObject == BF && threshhold == goal[Q])
       // {
          //  Q++;
          //  threshhold = 0;
          //  next.go = true;
        //}
    }
}
[Serializable]
public class lvls
{
    public GameObject[] mobsObjects;

   
}