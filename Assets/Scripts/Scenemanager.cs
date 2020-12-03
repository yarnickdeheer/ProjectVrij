using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanager : MonoBehaviour
{

    private string[] scenePaths;
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
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (endlevel)
        {
            Color temp = black.color;
            fade += 0.02f; if (fade > 1) fade = 1;  // from 0.0 to 1.0
            temp.a = fade;
            black.color = temp;

            if (fade == 1)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
    public void start()
    {
        BS.SetActive(true);
            endlevel = true;
        
    }
    public void quit()
    {
        Application.Quit();
    }
}