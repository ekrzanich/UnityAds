using UnityEngine;
using System.Collections;

public class PlayKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayClip () {
		this.GetComponent<AudioSource> ().Play ();
	}
}
