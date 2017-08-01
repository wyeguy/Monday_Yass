using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour {

	public AudioClip [] sfxClips;
	public AudioClip [] ostClips;
	public AudioSource SourceMusic;
	public AudioSource SourceSfx;



	public void PlaySfx(int TrackID){
		
		SourceSfx.PlayOneShot (sfxClips [TrackID]);
	}
	public void PlayMusicTrack(int TrackID){
		SourceMusic.PlayOneShot (ostClips [TrackID]);
	}

}
