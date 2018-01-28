using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class yetibutton : MonoBehaviour, IPointerDownHandler 

{

	　public GameObject qiti;
	public GameObject guti;
	public GameObject qicai;
	public GameObject yeti;


	　　　public void OnPointerDown(PointerEventData eventData)
	　　  {

		　　　yeti.SetActive(true);
		guti.SetActive(false);
		qiti.SetActive(false);
		qicai.SetActive(false);

		　　　}

	　　/*　public void OnPointerExit(PointerEventData eventData)

	　　  {
		//imgRect.localScale = imgNormalScale; 

		　　　　　//obj.SetActive(false);
		　　  }*/

}
