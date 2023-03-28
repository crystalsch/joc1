using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlaceableObjectManager : MonoBehaviour
{
    [SerializeField] PlaceableObjectContainer placeableObjects;
    [SerializeField] Tilemap targetTilemap;

    private void Start()
    {
        GameManager.instance.GetComponent<PlaceableObjectReferenceManager>().placeableObjectsManager = this;
    }

    public void Place(Item item, Vector3Int positionOnGrid)
    {
       
        GameObject go = Instantiate(item.itemPrefab);
        Vector3 position = targetTilemap.CellToWorld(positionOnGrid);
        go.transform.position = position;
        placeableObjects.placeableObjects.Add(new PlaceableObject(item, go.transform,positionOnGrid));
    }
}
