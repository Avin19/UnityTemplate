using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : MonoBehaviour
{
    [SerializeField] private RectTransform settingPanel;
    [SerializeField] private Button playBtn;
    [SerializeField] private Button levelBtn;
    [SerializeField] private Button settingBtn;
    [SerializeField] private TextMeshProUGUI levelText;


    void OnEnable()
    {
        settingBtn.onClick.AddListener(SettingPanelClicked);
    }
    void OnDisable()
    {
        settingBtn.onClick.RemoveAllListeners();
    }
    private void SettingPanelClicked()
    {
        settingPanel.gameObject.SetActive(true);
    }
    void Start()
    {
        levelText.text = PlayerDataManager.Instance.CurrentLevel.ToString();
    }
}
