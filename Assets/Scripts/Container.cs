using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
	private Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void ActivateKinematic()
	{
		rb.isKinematic = true;
	}

	public void DeactiveKinematic()
	{
		rb.isKinematic=false;
	}
}
