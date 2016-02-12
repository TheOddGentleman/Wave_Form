using UnityEngine;
using System.Collections;

public class JointTurbulence : MonoBehaviour {

	public Rigidbody2D thisRigidbody;

	public float turbulenceSpeed;
	public Vector2 turbulenceDirection;

	void FixedUpdate() {
		thisRigidbody.AddForce( turbulenceDirection * Random.Range( -turbulenceSpeed, turbulenceSpeed ) );
	}
}
