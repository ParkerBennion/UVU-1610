using UnityEditor;
using UnityEngine;

public class Rotating : MonoBehaviour
{
	//public GeometryUtility rotar; not what i needed
	//public PivotRotation rotam; not what i needed
	public CharacterController controller;
	public float rotate = 10f;
	public Vector3 rotation;

	public Vector3 position;
	public float speed = 100f;
	public float gravity = 3.4f;

	void Update () {
		//if (Input.GetButtonDown("Mouse X"))
		//{
		//	transform.rotation.x = position;
		//}
		rotation.x = rotate*Input.GetAxis("Mouse X");
		//rotation.y = rotate*Input.GetAxis("Mouse Y");
		
		//moved with mouse 
		//now going to attempt to apply gravity
		
		if (!controller.isGrounded)
		{
			position.y -= gravity;
		}
		//position shows to be falling but game object appears not to fall???
		controller.Move(rotation*Time.deltaTime);
		
	}
}
