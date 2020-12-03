using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fadein : MonoBehaviour
{
    public GameObject startT;
    public Image black;
    public bool endlevel;
    private float fade = -0.02f;
    private int begin;
    public startText T;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endlevel)
        {
            Color temp = black.color;
            temp.a = temp.a+fade;
            black.color = temp;
            if (temp.a <= 0)
            {
                //startT.SetActive(true);
                T.start = true;
            }

        }
      
    }
}
 