using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {

	public float speed;
	public float speed2;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 1f, 0f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -1f, 0f);
		}
	}
}
