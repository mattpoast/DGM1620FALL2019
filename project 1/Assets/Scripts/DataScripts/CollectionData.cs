using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu]
public class CollectionData : ScriptableObject
{
   public List<GameArtData> collectionList;

   public void AddData(GameArtData obj)
   {
      foreach (var gameArt in collectionList)
      {
         Debug.Log(gameArt);
      }
   }
}
