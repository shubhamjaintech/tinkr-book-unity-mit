using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class TinkerText : MonoBehaviour {
   
   // public Text tinkerText;
    public Stanza stanza;
    // Auto play timing related
    private float startTime;
    private float endTime;
    private float delayTime;
    public GameObject text;
    public Animator a;
    public Animation anim;


    // Use this for initialization
    void Start () {
        //a = text.GetComponent<Animator>();
        
        //anim = gameObject.GetComponent<Animation>();
        a = gameObject.GetComponent<Animator>();
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update () {
		
	}
    // Mouse Down Event
    public void OnMouseDown()
    {
        clipPlay();
    }

    public void OnMouseUp()
    {

        Debug.Log("on mouse up" + a.speed);
        a.SetTrigger("resume");
        //a.speed = 1/delayTime;

    }
    //public Animation GetAnimationClip(string name)
    //{
    //    if (!a) return null; // no animator

    //    //foreach (Animation clip in a.runtimeAnimatorController.animationC)
    //    //{
    //    //    if (clip.name == name)
    //    //    {
    //    //        return clip;
    //    //    }
    //    //}
    //    return null; // no clip by that name
    //}


    void clipPlay()
    {
        AudioSource source = gameObject.GetComponent<AudioSource>();
       
        //AudioClip wordClip = (AudioClip)Resources.Load("Audio/VO/child_tap_1") as AudioClip;
        //source.clip = wordClip;
        //float delaytime = 1.53f;
         delayTime = 0.21f;
        //text.GetComponent<Animator>().enabled = true;
        //Debug.Log("deepu"+a);
        a.speed = 1 / (delayTime);
        //play sound
        source.Play();
        //play animation
        //Debug.Log("b4"+a.speed);
        a.Play("textzoomout");
        //Debug.Log("a4" + a.speed);
        //a.speed = 1 / (delayTime * 2);

        //Debug.Log("check" + GameManager.mousepressed);
        //Debug.Log("check2" + anim.name);

        //if (GameManager.mousepressed && GetAnimationClip("textzoomout").normalizedTime == 0.5f)// && a.GetCurrentAnimatorStateInfo(0).normalizedTime == 0.5)
        //{
        //    Debug.Log("dasd");
        //    a.speed = 0;

        //    //float ak = (float)a.GetParameter(1);


        //    Time.timeScale = 0;

        //}

        //if (!anim.IsPlaying("textzoomout"))
        //    anim.Play("textzoom");
        //text.GetComponent<Animator>().enabled = false;
    }

}
