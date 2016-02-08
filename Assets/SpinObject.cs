// code from - http://blog.rabidgremlin.com/2015/01/11/tutorial-creating-your-first-unity-android-app-2015-update/

using UnityEngine;
using System.Collections;

public class SpinObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*90);
	}
}
