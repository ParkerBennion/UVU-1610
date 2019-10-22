using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CollectionData : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        collectionList.Add(obj);
    }

    //assets to project, game obj into scene
    //objs in the scene cannot be referenced back into the project
}
