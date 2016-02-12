using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D thisRigidbody;

	public float speed;
	public float jumpPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizInput = Input.GetAxis("Horizontal");

		if( Mathf.Abs( horizInput ) > 0f ) {
			thisRigidbody.AddForce( new Vector2( horizInput * speed, 0f ) );
		}

		if( Input.GetKeyDown( KeyCode.Space ) ) {
			thisRigidbody.AddForce( new Vector2( 0f, jumpPower ), ForceMode2D.Impulse );
		}
	}
}
