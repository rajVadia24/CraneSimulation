using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CraneMovement : MonoBehaviour
{
	[SerializeField] private List<SpringJoint> joints;

	private void OnEnable()
	{
		Events.onPlayerMoves += Move;
	}
	private void OnDisable()
	{
		Events.onPlayerMoves -= Move;
	}
	private void Move(float xDirection, float yDirection)
	{
		transform.Translate(Vector3.forward * yDirection * Time.deltaTime);
		transform.Translate(Vector3.right * xDirection * Time.deltaTime);
	}

}
