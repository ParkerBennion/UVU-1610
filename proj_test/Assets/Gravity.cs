using UnityEngine;

public class Gravity : MonoBehaviour
{
	private int jumpCount;
	public int jumpCountMax = 2;
	public Vector3 position;
	public float moveSpeed = 10f, grav = 9.3f, jumpSpeed = 30;

	private CharacterController _controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		position.x = moveSpeed* Input.GetAxis("Horizontal");
		position.y -= grav; // put negative before "=" if your adding jumping.
		
		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpCount++;
		}

		if (_controller.isGrounded)
		{
			position.y = 0;
			jumpCount = 0;
		}
	}
}
