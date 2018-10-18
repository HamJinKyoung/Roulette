using UnityEngine;
using System.Collections;

public class RouletteController : MonoBehaviour {

	// Use this for initialization
	float rotSpeed = 0; //회전속도

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//클릭하면 회전 속도를 설정한다.
		if (Input.GetMouseButtonDown (0)) {
			this.rotSpeed = 1;
		}
		else if (Input.GetMouseButton (0)) {
			this.rotSpeed *= 1.02f;
		}
		else {
			this.rotSpeed *= 0.96f;
		}

		transform.Rotate(0,0,this.rotSpeed);
	}
}
