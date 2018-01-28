using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class jiujingdeng :MonoBehaviour, IPointerDownHandler, IPointerExitHandler
{

	private RectTransform imgRect;  
	//Vector3 imgNormalScale = new Vector3(4.5f, 2.5f, 2.5f);   //正常大小
	//Vector3 imgReduceScale = new Vector3(5f,3f, 3);  

	　　　public GameObject obj;
	void Start () {
		imgRect = obj.GetComponent<RectTransform>();

	}

	　　　public void OnPointerDown(PointerEventData eventData)
	　　  {
		//imgRect.localScale = imgReduceScale; 
		　　　　obj.SetActive(true);
		　　　}

	　　　public void OnPointerExit(PointerEventData eventData)

	　　  {
		//imgRect.localScale = imgNormalScale; 

		　　　　　obj.SetActive(false);
		　　  }

}
