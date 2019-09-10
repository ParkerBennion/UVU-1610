//grey in code nomally means its not being used.
//putting float data in resources folder***
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float amount)
    {
        value += amount;
        //value = value + amount (this is the same thing)
    }
}
