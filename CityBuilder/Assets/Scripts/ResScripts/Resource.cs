using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource", menuName = "New Resource")]
public class Resource : ScriptableObject
{
    public string Name;

    public Sprite icon;
    public int MinAmount;
    public int MaxAmount;

    public virtual void UseResource ()
    {
        //Usage of the resource

        Debug.Log("Using " + Name);
    }
}
