using UnityEngine;
using System.Collections;

public class Operator : MonoBehaviour {
	public int valueOne = 10;
	public int valueTwo = 2;
	
	// Use this for initialization
	void Start () {
	/*Operators can be used to perform calculations, such as adding, subtracting,
	multiplication ect. this can also be used to create something like a counter
	for supplies, weapons, troops and what not.  */
	}
	
	// Update is called once per frame
	void Update () {
	
		//Addition	
	Debug.Log(valueOne + valueTwo);
		//Subtraction
	Debug.Log(valueTwo % valueOne);
		// multiplication
	Debug.Log(valueTwo * valueOne);
		//devision
	Debug.Log(valueOne / valueTwo);
		//increment
	Debug.Log(valueOne++);
		// decrement
	Debug.Log(valueTwo--);
	//for some reason this script was bringing up errors, you said to leave it 
	//because we couldn't find what was wrong.
	}
}
