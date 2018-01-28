using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {
	public Camera minimapCamera;
	public float minfiledView = 44f;
	public float maxfiledView = 95f;
	private Vector3 offsetPosition;

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void ZoomInButtonClick()
	{
		if (minimapCamera.fieldOfView > minfiledView)
		{
			minimapCamera.fieldOfView -= 1;
		}
		else
			minimapCamera.fieldOfView = minfiledView;
	}

	public void ZoomOutButtonClick()
	{
		if (minimapCamera.fieldOfView < maxfiledView)
		{
			minimapCamera.fieldOfView += 1;
		}
		else
			minimapCamera.fieldOfView = maxfiledView;
	}
}