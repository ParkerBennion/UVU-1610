
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public FloatData health;
    public ClothData shirt;
    public ClothData pants;
    public List<WeaponData> weapons;
}