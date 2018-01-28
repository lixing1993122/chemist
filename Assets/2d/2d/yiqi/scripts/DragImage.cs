using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
//拖动图片
public class DragImage : MonoBehaviour,IDragHandler {
	//保存图片的RectTransform信息
	private RectTransform rectTransform;

	// Use this for initialization
	void Start () {
		//获取图片的RectTransform信息
		rectTransform = GetComponent<RectTransform>();
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnDrag(PointerEventData eventData)
	{
		//获取鼠标的位置信息
		Vector3 position = Input.mousePosition;
		//在拖拽中实时更新图片的额位置信息
		rectTransform.position = new Vector3(position.x,position.y,rectTransform.position.z);
	}
}
