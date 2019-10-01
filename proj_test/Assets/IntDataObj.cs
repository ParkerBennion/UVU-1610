
using UnityEngine;
[CreateAssetMenu]
public class IntDataObj : ScriptableObject
{
	public int value = 1;

	public void UpdateValue(int number)
	{
		value += number;
	}
}
