using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour {
	//private  Animation m_anim;

	public float DirectionDampTime = .25f;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}


	void Update ()
	{
		if (animator == null) return;

		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		if (stateInfo.IsName("Base Layer.Run"))
		{
			if (Input.GetButton("Fire1"))
				animator.SetBool("apply", true);
		}
		else
			animator.SetBool("Jump", false);
		if (Input.GetButtonDown("Fire2") && animator.layerCount >= 2)
			animator.SetBool("Hi", true);
		else
			animator.SetBool("Hi", false);
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		animator.SetFloat("Speed", h * h + v * v);
		animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);
	}
}



	




	/*// 接触结束
	void OnTriggerExit2D(Collider2D collider) {
		Debug.Log("接触结束");
		Debug.Log (collider.name);
	}

	// 接触持续中

	void OnCollisionExit2D(Collision2D coll)  {
	
	}*/

