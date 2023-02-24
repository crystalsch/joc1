using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvetorySlot : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI text;

int myIndex;

public void SetIndex(int index)
{
    myIndex = index;

}
public void Set(ItemSlot slot)
{
    icon.gameObject.SetActive(true);
    icon.sprite = slot.item.icon;
    
    if (slot.item.stackable == true)
    {
        text.gameObject.SetActive(true);
        text.text = slot.count.ToString();
    }
    else
    {
        text.gameObject.SetActive(false);
    }
}
public void Clean()
{
    icon.sprite = null;
    icon.gameObject.SetActive(false);
    text.gameObject.SetActive(false);
}

}
