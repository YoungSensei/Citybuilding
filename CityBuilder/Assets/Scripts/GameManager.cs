using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player Stats")]
    public float WoodMod;
    public float StoneMod;
    public float FishMod;
    public float Harvesters;
    [Header("Player Resources")]
    public int Wood;
    public int Stone;
    public int Fish;

    public List<GameObject> Buildings; //Test Variable
    public int BNum;
    public bool TurnEnded;
    int TempMod;
    public void EndTurn()
    {
        TurnEnded = true;
        foreach (HarvestPoint HPoint in FindObjectsOfType<HarvestPoint>())
        {
            if (HPoint.Harvested == true)
            {
                HPoint.Results();
                HPoint.Harvested = false;
                TurnEnded = false;
                Harvesters++;
            }
        }
    }

    public void AddRes(int Res, int Amount)
    {
        switch (Res)
        {
            case 0:
                Wood += Amount;
                break;
            case 1:
                Stone += Amount;
                break;
            case 2:
                Fish += Amount;
                break;
        }
    }
    public int Modifiers(int WRes, int BGain)
    {
        switch (WRes)
        {
            case 0:
                TempMod = Mathf.RoundToInt(BGain * WoodMod);
                break;
            case 1:
                TempMod = Mathf.RoundToInt(BGain * StoneMod);
                break;
            case 2:
                TempMod = Mathf.RoundToInt(BGain * FishMod);
                break;
        }
        Debug.Log("Value Returned: " + TempMod + " from case Value: " + WRes);
        return TempMod;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //This is for CubePlacer Test
            BNum++;
            if (Buildings.Count <= BNum)
            {
                BNum = 0;
            }
          
            FindObjectOfType<CubePlacer>().Prefab = Buildings[BNum];

        }
    }
}
