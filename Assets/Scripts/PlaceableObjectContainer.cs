using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlaceableObject
{
    public Item placedItem;
    public Transform targetObject;
    public Vector3Int positionOnGrid;
    public PlaceableObject(Item item, Transform target, Vector3Int pos)
    {
        placedItem = item;
        targetObject = target;
        positionOnGrid = pos;                                                                                                         
    }
}


[CreateAssetMenu(menuName = "Data/Pleaceable Object Container")]
public class PlaceableObjectContainer : ScriptableObject
{
    public List<PlaceableObject> placeableObjects;
}