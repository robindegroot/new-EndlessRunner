using UnityEngine;
using System.Collections;

public class CouroutineScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (WaitAndPrint (2f));
	}
	
	IEnumerator WaitAndPrint(float waitTime)
	{
		while(true)
		{
			float translation = Time.deltaTime * 10;
			yield return null;
		}

	}
}
