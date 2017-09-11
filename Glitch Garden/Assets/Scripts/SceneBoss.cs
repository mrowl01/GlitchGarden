using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBoss : MonoBehaviour 
{
	public float splashLoadTime = 3f; 

	void Start ()
	{
		LoadInTime (splashLoadTime); 
	}

	public void SwitchToScene ( string theScene)
	{
		SceneManager.LoadScene (theScene); 
	}
	public void LoadNextScene()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}
	public void QuitGame ()
	{
		Application.Quit (); 
	}
	public void LoadInTime (float theTime)
	{
		Invoke ("LoadNextScene", theTime);
	}
	public int SceneImOnNow ()
	{
		int myCurrentScene = SceneManager.GetActiveScene().buildIndex; 
		return myCurrentScene;
	}

}
