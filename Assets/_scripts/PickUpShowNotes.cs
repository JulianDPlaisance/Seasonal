using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpShowNotes : MonoBehaviour
{
    const int MAXNOTES = 10;
    public int notesCollected = 0;
    bool imageOn = false, hitting = false;
    public Text[] texts;
    public string[] strings;
    public StringTextObjects[] NotesArg;
    public RaycastHit hit;
    public Ray ray;
    public Camera cameras;
    Transform objectHit;
    public GameObject endPanel;
    private void Start()
    {
        NotesArg = new StringTextObjects[MAXNOTES];
        for (int i = 0; i < MAXNOTES; i++)
        {
            NotesArg[i] = new StringTextObjects(texts[i], strings[i]);
        }
        notesCollected = 0;
    }

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "Notes" && hitting == false)
        {
            imageOn = true;
            showNotes(notesCollected);
            notesCollected++;
            Time.timeScale = 0.3f;
            hitting = true;
            Destroy(hit.collider.gameObject);
        }

        if(hitting == true && Input.GetButton("Jump"))
        {
            imageOn = false;
            showNotes(notesCollected - 1);
            Time.timeScale = 1f;
            hitting = false;
        }
        if(hitting == false && notesCollected == 10)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }

    public void showNotes(int num)
    {
        NotesArg[num].text.transform.parent.gameObject.SetActive(imageOn);
    }

    public class StringTextObjects
    {
        public Text text;

        public StringTextObjects(Text txt, string str)
        {
            text = txt;
            text.text = str;
        }
        public StringTextObjects()
        {

        }
    }
}
