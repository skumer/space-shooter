using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		while (other.tag == "Boundary") 
		{
			return;
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
