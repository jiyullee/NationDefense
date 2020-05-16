using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Gyeonggi : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    public City_Synergy City_Synergy { get; set; }

    private void Awake()
    {
        City_Synergy = GetComponent<City_Synergy>();
    }

    
}
