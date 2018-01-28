using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class light : MonoBehaviour

{


	　
	public GameObject ximie;
	public GameObject meigai;

	/*void start()
	{
		GameObject dianran = GameObject.FindWithTag ("ran");
	}*/




	public void onclick()
	{
		


		ximie.SetActive(false);
		meigai.transform.parent = null;
		meigai.SetActive (true);
	}

	public void fanhuiguanka()
	{
		SceneManager.LoadScene("guanka");  
	}
		　　　

	public void yichu(GameObject sender)  
	{ 

		　　　
		Destroy (meigai);



		　　　}

	　
}
