using UnityEngine;
    
[CreateAssetMenu]

public class PlayerDataA : ScriptableObject
{
  public Sprite sprite;
  public Color color;
  public GameObject prefab;

  public void InstancePlayer()
  {
   var newPlayer = Instantiate(prefab);
   var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
   newSprite.sprite = sprite;
   newSprite.color = color;
  }
}

