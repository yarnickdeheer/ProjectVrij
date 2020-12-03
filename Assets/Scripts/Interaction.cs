using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private enemyFollow[] seekers;
    private RockTrow throwScript;
    public Next mobs;
    public bool trown;
    //public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        if (trown == true)
        {
            for (int a = 0; a < mobs.lvlsystem[mobs.Q].mobsObjects.Length; a++)
            {
                mobs.lvlsystem[mobs.Q].mobsObjects[a].GetComponent<enemyFollow>().target = this.transform;
                // seekers[i].target = this.transform;
                mobs.lvlsystem[mobs.Q].mobsObjects[a].GetComponent<enemyFollow>().objective = true;

            }
        }
    }
    private void Awake()
    {
        //image = GameObject.FindGameObjectWithTag("indicatie");
        throwScript = GameObject.Find("trow").GetComponent<RockTrow>();
        GameObject[] seeker = GameObject.FindGameObjectsWithTag("seekers");
        seekers = new enemyFollow[seeker.Length];
        mobs = GameObject.Find("Player").GetComponent<Next>();
        for (int i = 0; i < seeker.Length; i++)
        {
            seekers[i] = seeker[i].GetComponent<enemyFollow>(); 
        }

      
        
     

         
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            throwScript.found = true;
           // image.SetActive(true);

       
        }
    }
}
 