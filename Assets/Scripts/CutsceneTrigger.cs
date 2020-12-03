using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

using UnityEngine.SceneManagement;


public class CutsceneTrigger : MonoBehaviour
{
    public GameObject[] Bushtrigger;
 
    public bool end = false;
    public int scene;
    public GameObject BS;
    public Image black;
    public bool endlevel;
    private float fade;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {

        if (end == true)
        {
            Color temp = black.color;
            fade += 0.06f; if (fade > 1) fade = 1;  // from 0.0 to 1.0
            temp.a = fade;
            black.color = temp;

            if (fade == 1)
            {
                SceneManager.LoadScene(scene);
            }

            

        }
      
       
   
    }
    
  
    

}
