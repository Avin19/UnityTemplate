using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHolder : MonoBehaviour
{
    [SerializeField] private Transform pfItem;
    [SerializeField] private Transform levelholder;

    [SerializeField] private int totalLevel = 10; // FOr now let uses this


    void Start()
    {
        for (int i = 0; i < totalLevel; i++)
        {
            GameObject Go = Instantiate(pfItem, levelholder).gameObject;
            Go.GetComponent<ItemDetail>().SetLevelText(i + 1);
        }
    }
}
