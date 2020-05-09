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
    private Synergy[] synergies;

    private void Awake()
    {
        synergies = FindObjectsOfType<Synergy>();
    }

    public void HideAllSynergyInfo()
    {       
        foreach (var synergy in synergies)
            synergy.HideSynergyInfo();
    }
}
