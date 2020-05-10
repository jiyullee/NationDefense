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
    [SerializeField] private int maxCount;
    [SerializeField] private int index;

    [SerializeField] Text synergyCountText;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        synergyInfo = transform.Find("SynergyInfo").gameObject;
    }

    private void Update()
    {
        synergyCountText.text = SynergyManager.Instance.Count[index].ToString() + "/" + maxCount.ToString();
    }

    public void ShowSynergyInfo()
    {
        SynergyManager.Instance.HideAllSynergyInfo();
        synergyInfo.SetActive(true);
        SynergyManager.Instance.OnPanels();
    }

    public void HideSynergyInfo()
    {
        synergyInfo.SetActive(false);
    }
    
}
