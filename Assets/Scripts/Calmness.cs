using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering;

public class Calmness : MonoBehaviour
{
    public GameObject Text;
    public Image bar;
    [HideInInspector]public float Cmeter= 0;
    private float maxM;
    private float minM;
    public bool save = false;
    public Image foto;
    public Sprite[] sprites;
    public Animator bear;
    public GameObject speler;
    public GameObject[] points;
    public Next Quest;
    public GameObject image;

    public PostProcessVolume ppProfiel;
    LensDistortion lens;
    Grain grain;
    AutoExposure AE;



    // Start is called before the first frame update
    void Start()
    {
        ppProfiel.profile.TryGetSettings<LensDistortion>(out lens);
        ppProfiel.profile.TryGetSettings<Grain>(out grain);
        ppProfiel.profile.TryGetSettings<AutoExposure>(out AE);
        minM = 0;
        maxM = 365;
        Text.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        bar.rectTransform.sizeDelta = new Vector2(Cmeter, 70.72f);
        if (Cmeter <= minM)
        {
            Cmeter = minM;
        }
        else if (Cmeter >= maxM)
        {
            Cmeter = maxM;
            StartCoroutine(Respawn());
        }
        if (Input.GetKey(KeyCode.E) && save == true)
        {
            Cmeter = Cmeter - 2;
            image.SetActive(false);
            bear.SetBool("hug", true);
        }else if(Input.GetKeyUp(KeyCode.E) && save == true)
            {
               
                bear.SetBool("hug", false);
            }


        if (Cmeter <= 121)
        {
            foto.sprite = sprites[0];
        }
        else if(Cmeter > 121 && Cmeter < 242){
            foto.sprite = sprites[1];
        }
        else if (Cmeter > 242 && Cmeter <= 365)
        {
            foto.sprite = sprites[2];
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "hiding")
        {
            Text.SetActive(true);
            save = true;
           
        }
    }
    
    public IEnumerator Respawn()
    {
        image.SetActive(true);
       
        yield return new WaitForSeconds(5f);
        image.SetActive(false);
        if (Cmeter == maxM)
        {
            
            speler.transform.position = points[Quest.Q].transform.position;
            Cmeter = 0;
           
            lens.intensity.value = 1;
            lens.intensityX.value = 0;
            lens.intensityY.value = 0;
            lens.centerX.value = 0;
            lens.centerY.value = 0;

            grain.intensity.value = 0;
            grain.size.value =  0.3f;
            grain.lumContrib.value = 0;

            AE.minLuminance.value = 0;
        }
    }
private void OnTriggerExit(Collider coll)
{
    if (coll.gameObject.tag == "hiding")
    {
        Text.SetActive(false);
            save = false;
            bear.SetBool("hug", false);
        }
}
}
