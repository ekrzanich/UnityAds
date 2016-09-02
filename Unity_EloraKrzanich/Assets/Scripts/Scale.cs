using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;

public class Scale : MonoBehaviour {

	public GameObject[] notes = new GameObject[8];
	private List<GameObject> displayNotes = new List<GameObject> ();
	private float currentXPos = 0f;
	// Use this for initialization
	void Start () {
		ResetXPos ();
	}

	// Update is called once per frame
	void Update () {

	}

	private void ResetXPos()
	{
		currentXPos = 0;
	}

	public void ClearDisplay()
	{
		for (int i = 0; i < displayNotes.Count; i++) {
			GameObject.Destroy (displayNotes [i]);
		}

		displayNotes.Clear ();
		ResetXPos ();

		if (Advertisement.IsReady()) {
			Advertisement.Show ();
		}
	}

	public void AddNote( int note )
	{
		if (displayNotes.Count < 8) {
			GameObject newNote = (GameObject)GameObject.Instantiate (notes [note]);
			newNote.transform.localPosition = new Vector3 (currentXPos, 0.25f * note);
			newNote.GetComponent<RectTransform> ().SetParent (this.GetComponent<RectTransform> ().transform);
			displayNotes.Add (newNote);
			currentXPos += notes [note].GetComponent<SpriteRenderer> ().bounds.size.x;
		}
	}
}
