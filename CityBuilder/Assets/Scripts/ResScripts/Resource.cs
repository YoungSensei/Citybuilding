using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource", menuName = "New Resource")]
public class Resource : ScriptableObject
{
    public string Name;
    public int MinAmount;
    public int MaxAmount;
}
