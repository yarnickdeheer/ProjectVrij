using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class Sound : MonoBehaviour
{
    public GameObject player;
    public Transform[] traps;
    public enemyFollow[] seekers;
    public FirstPersonController controller;
    public AudioClip wet;
    public AudioClip[] dry;
    public Next mobs;
    public CutsceneTrigger man;
    public AudioClip breakT;
    public AudioSource source;

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
        if (coll.gameObject.tag == "end")
        {
            man.end = true;
        }
        if (coll.gameObject.tag == "interact") 
        {
            for (int i = 0; i < traps.Length; i++)
            {
                if (coll.gameObject.transform == traps[i])
                {
                    Debug.Log("ja" + traps[i].gameObject.name);
                    source.PlayOneShot(breakT);

                    for (int a = 0; a < mobs.lvlsystem[mobs.Q].mobsObjects.Length; a++)
                    {
                       
                        mobs.lvlsystem[mobs.Q].mobsObjects[a].GetComponent<enemyFollow>().target = coll.gameObject.transform;
                        mobs.lvlsystem[mobs.Q].mobsObjects[a].GetComponent<enemyFollow>().objective = true;
                        mobs.lvlsystem[mobs.Q].mobsObjects[a].GetComponent<enemyFollow>().foundTarget = true;
                    }
                }
            }
            Debug.Log("interact");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               
            }
        }
      
        // Debug.Log(coll.gameObject.name);
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 1)
        {
            controller.m_WalkSpeed = 2;
            controller.m_RunSpeed = 4;
            controller.m_FootstepSounds[0] = wet;
            controller.m_FootstepSounds[1] = wet;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 1)
        {
            controller.m_WalkSpeed =5;
            controller.m_RunSpeed = 8;
            controller.m_FootstepSounds[0] = dry[0];
            controller.m_FootstepSounds[1] = dry[1];
        }
    }

}
