using UnityEngine;
using System.Collections;
using System.IO;
using System;


public class OpenPicture : MonoBehaviour
{
	public Texture2D _texture;
	public GameObject DaYangTu;

	IEnumerator Open()
	{
		string path = Application.persistentDataPath + "/pics" + "/1.jpg";
		WWW www = new WWW("file://" + path);
		yield return www;
		Debug.Log(":" + www.error);
		_texture = new Texture2D(300, 300);
		_texture = www.texture;
		//DaYangTu.GetComponent<UITexture>().mainTexture = _texture;
	}

	public void OnClick()
	{
		DaYangTu.SetActive(true);
		StartCoroutine(Open());
	}
	// Update is called once per frame
	void Update () {

	}
}
