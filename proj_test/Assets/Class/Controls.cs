using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Animations;

public class Controls : MonoBehaviour
{
	public Vector3 position;
	public CharacterController controller;
	public float speed = 100f;
	public float gravity = 3.4f;
	public float jumpSpeed = 10f;
	public float rotate = 90;
	
	void Update () {
		position.x = speed*Input.GetAxis("Horizontal");
		if (!controller.isGrounded)
		{
			position.y -= gravity;
		}
		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}

		controller.Move(position*Time.deltaTime);
	}
}
