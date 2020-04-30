using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] protected string cityName;
    [SerializeField] protected Text nameText;
    [SerializeField] SpriteRenderer spriteRenderer;
    void Start()
    {
        
    }

    public void Infect_New()
    {
        spriteRenderer.color = Color.red;
        gameObject.tag = "Infect";
    }

    public void Infect_Old()
    {
        
        
    }
}
