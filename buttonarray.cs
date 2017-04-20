using UnityEngine;
using System.Collections;

public class buttonarray : MonoBehaviour {
	public int[] clickarray;

	
	public void addarray() {
	 int[] temp = new int[clickarray.Length + 1];
	 clickarray.CopyTo(temp, 0);
	 clickarray = temp;
	 clickarray[clickarray.Length - 1] = clickarray.Length - 1;
		
	}
}
	
	
	
	
	

	

