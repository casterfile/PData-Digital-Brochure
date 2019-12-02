using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
	public string Name;
	// Use this for initialization
	public void Change () {
		Application.LoadLevel(Name);
	}
}
