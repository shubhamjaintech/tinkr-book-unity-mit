using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
    
public class TinkerText : MonoBehaviour {
    private static bool check=false;
    public TinkerText pairedTinkerText;
    public TinkerGraphic tinkerGraphic;
    public static bool pairedgraphic = false;
   // public Text tinkerText;
    public Stanza stanza;
    // Auto play timing related
    private float startTime;
    private float endTime;
    private float delayTime;
    //public GameObject text;
    private Animator wordanimator;
    private Animator iconanimator;
    private Animator graphicanimator;
    // private Animator animshit;
    public GameObject anim;
    //egg crack
    public GameObject anim2;
    public static int nooftaps;
    public static int tapcheck;



    // Use this for initialization
    void Start () {

        wordanimator = GetComponent<Animator>();
        if(anim!=null)
        iconanimator = anim.GetComponent<Animator>();
        if(anim2!=null)
        graphicanimator = anim2.GetComponent<Animator>();
       //Debug.Log(wordanimator + "    " + iconanimator+"       "+graphicanimator);
    }

    // Update is called once per frame
    void Update () {
		
	}
    // Mouse Down Event
    public void OnMouseDown()
    {
        clipPlay();

        iconanimPlay();
        if(tinkerGraphic!=null)
        graphicPlay();
        
    }

    public void OnMouseUp()
    {
        Debug.Log("on mouse up" + wordanimator.speed);
        //if(!pairedgraphic)
        clipResume();
        if (nooftaps < 2)
            iconanimator.SetTrigger("tapup");
      if(tinkerGraphic!=null)
            tinkerGraphic.OnMouseUp();
        
        //wordanimator.SetTrigger("resume");
        anim.SetActive(false);
    }
    //public void clipResume() {
    //    StartCoroutine(clipResu());
    //}
    public void clipResume()
    {


        if (nooftaps > 2)
        {

            if (pairedTinkerText != null)
            {
                pairedTinkerText.clipPlay();
                pairedTinkerText.clipResume();
            }
        }
        else {
            wordanimator.SetTrigger("resume");
        }
        
    }
    public void clipPlay()
    {

        if (nooftaps < 2||check)
        {
            check = false;
            Debug.Log("entered clip play");
            AudioSource source = gameObject.GetComponent<AudioSource>();
            delayTime = 0.21f;
            wordanimator.speed = 1 / (delayTime);
            Debug.Log("source play");

            source.Play();

            wordanimator.SetTrigger("tapme");
            //Debug.Log("clip play " + pairedgraphic);
            Debug.Log("tapcounttext: " + nooftaps);
        }
        else {
            //Debug.Log("else clip play");
            if (pairedTinkerText != null)
            {
                Debug.Log("else clip play");
                check = true;
                pairedTinkerText.clipPlay();
                pairedTinkerText.clipResume();
                //animshit.SetTrigger("crack3");

            }
        }


    }
    public void iconanimPlay()
    {
        if (nooftaps < 2)
        {
            anim.SetActive(true);
            iconanimator.SetTrigger("tap");
        }
    }
    //public void graphicPlay()
    //{

    //    StartCoroutine(graphicPla());
    //}
    public void graphicPlay()
    {
        if (anim2 != null)
            anim2.SetActive(true);
        if (graphicanimator != null)
        {
            if (nooftaps < 2)
            {
                int i = nooftaps + 1;
                graphicanimator.SetTrigger("crack" + i);
                nooftaps++;
            }
            else
            {
                

                //clipPlay();
                //clipResume();

                graphicanimator.SetTrigger("crack3");
                //SceneManager.LoadScene("Scene02");
                //yield return new WaitForSeconds(50);
                //yield return new WaitForEndOfFrame();
                //yield return WaitForEndOfFrame("textzoomin");
                
            }
        }
        }
    }
