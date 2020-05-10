using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Chungnam : MonoBehaviour
{
    [SerializeField] private City_Synergy city_Synergy;

    public City_Synergy City_Synergy { get => city_Synergy; set => city_Synergy = value; }

    private void Awake()
    {
        city_Synergy = GetComponent<City_Synergy>();
    }
}
