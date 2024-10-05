using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using this website to help figure this out
// https://gamedevbeginner.com/how-to-make-an-inventory-system-in-unity/
[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;

    [TextArea]
    public string description;
    public int value;
}
