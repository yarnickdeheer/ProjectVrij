using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawn : MonoBehaviour
{
    public GameObject player;
    public Transform spawnP;

    public Transform SecondspawnP;
    public QuestCol nextcheck;
    //public bool switch

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
        if (other.gameObject == player && nextcheck.used ==true)
        {
            player.transform.position = SecondspawnP.position;
        }
        else if (other.gameObject == player && nextcheck.used == false)
        {
            player.transform.position = new Vector3(spawnP.position.x, spawnP.position.y, spawnP.position.z);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player && nextcheck.used == true)
        {
            player.transform.position = SecondspawnP.position;
        }
        else if (other.gameObject == player && nextcheck.used == false)
        {
            player.transform.position = new Vector3(spawnP.position.x, spawnP.position.y, spawnP.position.z);
        }

    }
}
