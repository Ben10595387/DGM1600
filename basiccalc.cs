using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class basiccalc : MonoBehaviour {


		public InputField firstnumber;
		public InputField secondnumber;
		public Text output;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	public void Proses () {

		int variabelSementara;

		variabelSementara = int.Parse(firstnumber.text) + int.Parse(secondnumber.text);

		output.text = variabelSementara.ToString();
	}
}
