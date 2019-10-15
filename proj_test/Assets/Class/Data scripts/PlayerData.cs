
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public UnityAction<GameObject> InstanceAction; // 1
    public FloatData health;
    public ClothData shirt;
    public ClothData pants;
    public List<WeaponData> weapons;

    public void
    {
        var newPlayer = Instantiate(prefab);
        var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        playerSprite.sprite = sprite;
        playerSprite.color = spriteColor;
        InstanceAction(newPlayer); // 1
    }
}