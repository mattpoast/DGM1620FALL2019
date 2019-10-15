using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public FloatData health;
    public ClothesData shirt;
    public ClothesData pants;
    public List<WeaponData> weapons;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        playerSprite.sprite = sprite;
        playerSprite.color = spriteColor;
    }
}


