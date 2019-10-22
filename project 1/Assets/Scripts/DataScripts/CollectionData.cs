using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu]
public class CollectionData : ScriptableObject
{
   public List<GameArtData> collectionList;

   public void AddData(GameArtData obj)
   {
      collectionList.Add(obj);
   }
}
