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
        if (go.tag == "text") {
           // TinkerText tinkerText = go.transform.parent.GetComponent<TinkerText>();

            //do something related to tinkertext
            //clip
            //animation
            //if (stanzaManager != null)
            //    {
                   stanzaManager.OnMouseDown(go.GetComponent<TinkerText>());
                //}
            


        }
        
    }
    public virtual void OnMouseUp(GameObject go)
    {
        if (go.tag == "text")
        {
            // TinkerText tinkerText = go.transform.parent.GetComponent<TinkerText>();

            //do something related to tinkertext
            //clip
            //animation
            //if (stanzaManager != null)
            //    {
            stanzaManager.OnMouseUp(go.GetComponent<TinkerText>());
            //}



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
