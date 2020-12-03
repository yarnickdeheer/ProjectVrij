using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCol : MonoBehaviour
{
    public Next player;
    public GameObject speler;
    public bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject == speler && used == false)
        {
            used = true;
            player.threshhold++;

        }
    }
}
