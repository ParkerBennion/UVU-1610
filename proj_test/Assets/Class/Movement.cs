using UnityEngine;

public class Movement : MonoBehaviour 
{
	public Vector3 position;
	public CharacterController controller;
	public float speed = 10f;
	public float gravity = -3f;
	public float jumpSpeed = 10f;
	void Update () 
	{
		//transform.Translate(position*Time.deltaTime);//used for box collider
		position.x = speed;
		position.y = gravity;
		position *= Time.deltaTime * Input.GetAxis("Horizontal");
		position *= Time.deltaTime * Input.GetAxis("Vertical");
		controller.Move(position);//used for charicter controllers
		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}
		//position.x = speed*Input.GetAxis("Horizontal");
		//if (!controller.isGrounded)
		//{
		//position.y -= gravity
		//}
		//if (Imput.GetButtonDown("Jump"))
		//{
		//position.y = jumpSpeed;
		//}
		//controller.Move(position*Time.deltaTime);
	}
}
