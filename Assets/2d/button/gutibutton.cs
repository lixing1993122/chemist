using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class gutibutton : MonoBehaviour, IPointerDownHandler

{


	　　　public GameObject qiti;
	public GameObject guti;
	public GameObject qicai;
	public GameObject yeti;

	　　　public void OnPointerDown(PointerEventData eventData)
	　　  {

		　　　　guti.SetActive(true);
		qiti.SetActive(false);
		yeti.SetActive(false);
		qicai.SetActive(false);

		　　　}

	　　　

}
