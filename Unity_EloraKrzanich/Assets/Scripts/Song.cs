using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Song : MonoBehaviour {

	public AudioClip[] possibleNotes = new AudioClip[8];
	private List<AudioClip> fullSong = new List<AudioClip>();
	private bool isPlaying = false;
	private int currentNote = 0;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlaying) {
			if (!audioSource.isPlaying && fullSong.Count > currentNote) {
				audioSource.clip = fullSong[currentNote];
				audioSource.Play ();
				currentNote++;
			}
		}
	}

	public void AddNote( int note )
	{
		if (fullSong.Count < 8) {
			fullSong.Add (possibleNotes [note]);
		}
	}

	public void ClearSong()
	{
		fullSong.Clear ();

	}

	public void PlaySong()
	{
		isPlaying = true;
		currentNote = 0;
	}

	public void StopSong()
	{
		isPlaying = false;
	}
}
