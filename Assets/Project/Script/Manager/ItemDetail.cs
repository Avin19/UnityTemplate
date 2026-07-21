using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemDetail : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;
    private int level;


    public void SetLevelText(int _level)
    {
        level = _level;
        levelText.text = level.ToString();
    }


}
