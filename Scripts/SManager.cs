using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SManager : MonoBehaviour {
    [HideInInspector]
    public GameManager gameManager;

    // Manager for all things TinkerText
    public StanzaManager stanzaManager;
    //public TinkerText tinkerText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public virtual void OnMouseDown(GameObject go)
    {
        Debug.Log(go.tag);
        if (go.tag == "text")
        {
            stanzaManager.OnMouseDown(go.GetComponent<TinkerText>());

        }
        else {
            Debug.Log("graphic");
            stanzaManager.OnMouseDown(go.GetComponent<TinkerGraphic>());

        }

    }
    public virtual void OnMouseUp(GameObject go)
    {
        if (go.tag == "text")
        {
            stanzaManager.OnMouseUp(go.GetComponent<TinkerText>());
        }
        else if(go.tag=="graphic"){
            stanzaManager.OnMouseUp(go.GetComponent<TinkerGraphic>());
        }
    }
    // Here we have a superclass intercept for catching global TinkerGraphic mouse down events
    public virtual void OnMouseDown(TinkerGraphic tinkerGraphic)
    {


        //if (tinkerGraphic.pairedText != null)
        //{
        //    stanzaManager.OnPairedMouseDown(tinkerGraphic.pairedText);
        //}
    }

}
