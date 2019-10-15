using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineVirtualCamera))] // you need to enable cinemachine for this to work

public class CineControl : MonoBehaviour
{
	public PlayerData playerdata;
	private CinemachineVirtualCamera _virtualCamera;

	private void Awake()
	{
		virtualCamera = GetComponent<CinemachineVirtualCamera>();
		playerdata.InstanceAction = InstanceHandler;
		playerdata.InstancePlayer();
	}
	private void InstanceHandler(GameObject obj);
	{
		virtualCamera.Follow = object.transform;
	}
	
}
