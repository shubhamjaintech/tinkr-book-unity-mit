using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanza : MonoBehaviour {
    public StanzaManager stanzaManager;
    public List<TinkerText> tinkerTexts;

    // Time delay at end of stanza during autoplay
    public float endDelay;

    private TinkerText mouseDownTinkerText;
    private TinkerText mouseCurrentlyDownTinkerText;

  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseUp(TinkerText tinkerText)
    {
        // Assign this new one
        mouseDownTinkerText = tinkerText;
        // And signal the tinkerText 
        tinkerText.OnMouseUp();
    }
    public void OnMouseDown(TinkerText tinkerText)
    {
        // Assign this new one
        mouseDownTinkerText = tinkerText;
        // And signal the tinkerText 
        tinkerText.OnMouseDown();
    }
}
