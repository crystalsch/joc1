using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Tool Action/Place")]
public class PlaceAction : ToolAction
{
    public virtual bool OnApplyToTileMap(Vector3Int gridPosition, TileMapReadController tileMapReadController, Item item)
    {

        tileMapReadController.objectsManager.Place(item,gridPosition);
        return true;
    }
}