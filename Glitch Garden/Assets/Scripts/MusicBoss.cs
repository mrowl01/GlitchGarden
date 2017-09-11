using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicBoss : MonoBehaviour 
{

	public AudioClip [] levelMusic ; 
	AudioSource audioSource ;

	void Awake ()
	{
		DontDestroyOnLoad (gameObject); 
		// Keeps this audio source object forever
	}

	void Start ()
	{
		audioSource = gameObject.GetComponent<AudioSource> ();
		SceneManager.sceneLoaded += OnLevelLoaded;
	}
	void OnLevelLoaded (Scene scene, LoadSceneMode mode)// mode is just a delegate required in order for SceneManger.SceneLoaded to give us the current scene we are on (it is a delegate) 
	{
		AudioClip audioClip = levelMusic [scene.buildIndex]; // using scene given to us by scenemanager and delegate we make the music the array + the level  and play clip 
		if (audioClip) 
		{
			audioSource.clip = audioClip; 
			audioSource.loop = true;
			audioSource.Play (); 
		}
			
	}

}