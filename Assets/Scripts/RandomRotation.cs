using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour
{
	public float tumble;
	
	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}