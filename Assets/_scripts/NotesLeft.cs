using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesLeft : MonoBehaviour
{
    public PickUpShowNotes noted;
    public UnityEngine.UI.Text texty;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        texty.text = "Notes: " + noted.notesCollected + " / 10";
	}
}
