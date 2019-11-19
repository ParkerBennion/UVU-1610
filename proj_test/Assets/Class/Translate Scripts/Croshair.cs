using UnityEngine;

[RequireComponent(typeof(CharacterController))]
//this code demands a character controller and will make one when this script is applied
public class Croshair : MonoBehaviour
{
	private CharacterController controller;
	public float speed = 100f;
	public Vector3 position;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	void Update () {
		position.x = speed*Input.GetAxis("Mouse X");
		position.y = speed*Input.GetAxis("Mouse Y");

		controller.Move(position*Time.deltaTime);
		
	}
	
}
