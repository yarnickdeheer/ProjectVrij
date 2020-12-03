using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startText : MonoBehaviour
{
    public GameObject BS;
    public Text black;
    public bool start;
    private float fade = -0.03f;
    private int begin;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            Color temp = black.color;
            temp.a = temp.a + fade;
            black.color = temp;


        }
    }
}
