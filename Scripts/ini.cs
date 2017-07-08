using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ini : MonoBehaviour {

	private Vector3[] positionArray = new Vector3[10];
	private float[] times = new float[10];
	private int[] inst = new int[10];
	private int posIndex;
	private int listLength;
	public int scale;

	//speed
	private float moveSpeed;
	private float currTime;
	private float distance;
	private float iniTime;

	public GameObject flie;
	void Start () {
		positionArray[0] = new Vector3(1f, 1f, 1f);
		positionArray[1] = new Vector3(2.89f, 0f, 0f);
		positionArray[2] = new Vector3(5.684f, 0.077f, 0.088f);
		positionArray[3] = new Vector3(8.325f, 0.883f, 0.371f);
		positionArray[4] = new Vector3(10.92f, 0.092f, 0.953f);
		positionArray[5] = new Vector3(12.815f, 0.041f, 0.959f);
		positionArray[6] = new Vector3(18.4f, 0.647f, -0.147f);
		positionArray[7] = new Vector3(21.296f, 0.476f, -0.416f);
		positionArray[8] = new Vector3(25.414f, 0.231f, -0.771f);
		positionArray[9] = new Vector3(28.692f, 0.104f, -0.097f);


		times [0] = 1f;
		times [1] = 3f;
		times [2] = 6f;
		times [3] = 7f;
		times [4] = 10f;
		times [5] = 11f;
		times [6] = 15f;
		times [7] = 16f;
		times [8] = 18f;
		times [9] = 20f;

		inst [0] = 0;
		inst [1] = 0;
		inst [2] = 0;
		inst [3] = 0;
		inst [4] = 0;
		inst [5] = 1;
		inst [6] = 1;
		inst [7] = 1;
		inst [8] = 1;
		inst [9] = 1;




		posIndex = 0;
		listLength = positionArray.Length;
	}


	void Update () {
		currTime = Time.realtimeSinceStartup;
		if (currTime>times[posIndex]){
			transform.position = positionArray [posIndex]/scale;
			init ();
			posIndex++;
		}

	}

	void init (){
		Instantiate(flie, positionArray [posIndex], Quaternion.identity);
	}
}