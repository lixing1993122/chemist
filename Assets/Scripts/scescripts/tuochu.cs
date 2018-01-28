using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tuochu : MonoBehaviour {

	public GameObject cube;
	//public float produceRate = 0.5f;
	//private float nextProduce = 0;
	// Update is called once per frame
	void Start () {
		Button btn = this.GetComponent<Button> ();
		btn.onClick.AddListener (OnClick);
	}
	private void OnClick(){
		Vector3 position = new Vector3(0,0,0);
		GameObject clone = Instantiate(cube, position, cube.transform.rotation) as GameObject;
	}
	/*void Update()
	{
		//Fire1默认对应摇杆的0号按键(鼠标左键)
		if (Input.GetButtonDown("Fire1"))
		{
			
			//当按下Fire1键时，每0.5秒生成一个汽车.
			Vector3 position = new Vector3(0,0,0);
			GameObject clone = Instantiate(cube, position, cube.transform.rotation) as GameObject;
		}
	}*/

}
