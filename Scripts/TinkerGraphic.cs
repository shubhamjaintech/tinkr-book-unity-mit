using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TinkerGraphic : MonoBehaviour {
    private Animator anim;
    public TinkerText tink;
    public TinkerText poptink;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();	
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseUp()
    {
        TinkerText.pairedgraphic = false;
    }
        public void OnMouseDown()
    {
        TinkerText.pairedgraphic = true;
        graphicPlay();
       

    }
    public void graphicPlay()
    {
        if (anim != null)
        {
            if (TinkerText.nooftaps < 2)
            {
                tink.clipPlay();
                int i = TinkerText.nooftaps + 1;
                anim.SetTrigger("crack" + i);
                TinkerText.nooftaps++;
            }
            else
            {
                poptink.clipPlay();
                
                anim.SetTrigger("crack3");
                SceneManager.LoadScene("Scene02");
            }
        }
    }
        public void clipPlay() {

        if (anim != null)
        {
            if (TinkerText.nooftaps < 2)
            {
                int i = TinkerText.nooftaps + 1;
                anim.SetTrigger("crack" + i);
                TinkerText.nooftaps++;
            }
            else
            {
                anim.SetTrigger("crack3");
                SceneManager.LoadScene("Scene02");
            }
        }


    }



}
