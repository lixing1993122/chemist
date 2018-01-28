using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class tanchubutton : MonoBehaviour, IPointerDownHandler,  
 IPointerExitHandler
{


	　　　public GameObject obj;


	　　　public void OnPointerDown(PointerEventData eventData)
	　　  {
		
		　　　　obj.SetActive(true);

		　　　}

	　　　public void OnPointerExit(PointerEventData eventData)

	　　  {
		//imgRect.localScale = imgNormalScale; 

		　　　　　obj.SetActive(false);
		　　  }

}

