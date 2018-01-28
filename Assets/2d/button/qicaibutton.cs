using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class qicaibutton :MonoBehaviour, IPointerDownHandler
{
	public GameObject qicai;
	Vector2 offset = new Vector3(); 

	bool mousedown;

	　　　public GameObject qiti;
	public GameObject guti;
	//public GameObject qicai;
	public GameObject yeti;

	　　　public void OnPointerDown(PointerEventData eventData)
	　　  {
		offset = Vector2.zero;
		if(mousedown)
		{
			qicai.SetActive(false);
			mousedown =false;
		}
		else
		{
			qicai.SetActive(true);
			mousedown=true;
		}
		　　　//　qicai.SetActive(true);
		guti.SetActive(false);
		yeti.SetActive(false);
		qiti.SetActive(false);

		　　　}
	

	　　　

}