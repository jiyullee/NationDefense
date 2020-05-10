using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Synergy : MonoBehaviour
{
    private City city;
    private bool isSynergy;

    public bool IsSynergy { get => isSynergy; set => isSynergy = value; }

    private void Awake()
    {
        city = GetComponent<City>();
    }
    void Start()
    {
        StartCoroutine(Synergy());
    }

    IEnumerator Synergy()
    {
        while (true)
        {
            if(gameObject.layer == 10)
            {
                isSynergy = true;
            }
            else
            {
                isSynergy = false;
            }
            yield return null;
        }
    }
}
