using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using CodeMonkey.Utils;
public class Synergy : MonoBehaviour
{
    private static Synergy instance;
    [SerializeField] private string synergyName;
    private GameObject synergyInfo;
    Button_UI button_UI;
    private void Awake()
    {
        instance = this;
        button_UI = GetComponent<Button_UI>();
    }
    private void Start()
    {
        synergyInfo = transform.Find("SynergyInfo").gameObject;
    }

    public void ShowSynergyInfo()
    {
        SynergyManager.Instance.HideAllSynergyInfo();
        synergyInfo.SetActive(true);
    }

    public void HideSynergyInfo()
    {
        synergyInfo.SetActive(false);
    }
    
}
