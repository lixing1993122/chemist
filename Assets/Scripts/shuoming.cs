using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shuoming : MonoBehaviour {
	public GameObject panel;
	public AudioSource audioSource;
	// Use this for initialization

	void Awake()
	{
		


		audioSource = GetComponent<AudioSource> ();
		audioSource.loop = true;
		audioSource.playOnAwake = true;


	}



	void Start () {
		panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click()
	{
		panel.SetActive (true);
	}

	public void OnClick()
	{
		SceneManager.LoadScene ("guanka");
	}
	public void fanhui()
	{
		panel.SetActive (false);
		
	}




	public void PlayBGM(string name)
	{
		

		audioSource.Play ();

	}

	//播放暂停
	public void StopBGM()
	{

		audioSource.Stop ();
	}
}

