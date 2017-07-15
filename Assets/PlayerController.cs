using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		//获取水平轴的值
		float h = Input.GetAxis("Horizontal");
		//获取垂直轴的值
		float v = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (h, 0f, v);
		rigidbody.velocity = movement * 10;
	}
}
