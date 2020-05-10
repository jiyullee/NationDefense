using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SynergyManager : MonoBehaviour
{
    private static SynergyManager instance;
    public static SynergyManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SynergyManager>();
            }
            return instance;
        }
    }

    public int[] Count { get => count; set => count = value; }

    private Synergy[] synergies;

    [SerializeField] private int[] count = new int[8];
    private City[] cities;
    private string[] stateNames;

    [SerializeField] private GameObject[] panels;

    private void Awake()
    {
        synergies = FindObjectsOfType<Synergy>();

        cities = FindObjectsOfType<City>();
        stateNames = new string[] { "경기도", "강원도", "충청북도", "충청남도", "경상북도", "경상남도", "전라북도", "전라남도" };
    }

    private void Start()
    {
        StartCoroutine(CountSynergy());
    }

    IEnumerator CountSynergy()
    {
        while (true)
        {
            for (int i = 0; i < stateNames.Length; i++)
            {
                count[i] = CountEachSynergy(stateNames[i]);
            }
            yield return null;
        }
    }

    private int CountEachSynergy(string stateName)
    {
        int count = 0;
        foreach(var city in cities)
        {
            if(city.StateName == stateName)
            {
                if (city.City_Synergy.IsSynergy)
                    count++;
            }
        }
        return count;
    }

    public void HideAllSynergyInfo()
    {       
        foreach (var synergy in synergies)
            synergy.HideSynergyInfo();
        OffPanels();
    }

    public void OffPanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }
    public void OnPanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(true);
        }
    }
}
