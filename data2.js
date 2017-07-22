#pragma strict

//declaring variables
private var currTime=0f;
private var posIndex=0;
private var count:int=0;
var cloneCount=15;
var scale=200;

//object to be cloned
var mosquito: GameObject;
//array of instantiated objects
var clone : ArrayList;

//at the start of the code
function Start () {
	clone=new ArrayList();
}

function Update () {
	currTime = Time.realtimeSinceStartup;
	fly();
}

function fly() {
	if (currTime>data.times[posIndex]){
		var location = data.positionArray [posIndex]/scale;
		transform.position = location;
		var newClone=Instantiate(mosquito, (data.positionArray [posIndex+cloneCount]/scale), Quaternion.identity);
		clone.Add(newClone.gameObject);
		if (clone.Count>cloneCount) {
			Destroy(clone[posIndex-cloneCount]);
		}
		posIndex++;
		if (posIndex>data.positionArray.length) {
			posIndex=0;
		}
	}
}
