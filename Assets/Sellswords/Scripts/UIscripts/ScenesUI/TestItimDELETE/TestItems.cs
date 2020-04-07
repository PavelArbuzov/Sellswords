﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class TestItems : ScriptableObject
{
    public int count;
    new public string name = "New Item";    // Name of the item
    public Sprite icon = null;              // Item icon
    public bool showInInventory = true;


}