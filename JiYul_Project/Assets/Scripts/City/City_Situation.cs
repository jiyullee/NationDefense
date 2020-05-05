using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Situation : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    private City city;
    private City_Damage City_Damage;
    void Start()
    {
        city = GetComponent<City>();
        City_Damage = GetComponent<City_Damage>();
        StartCoroutine(Situation());
    }

    IEnumerator Situation()
    {
        while (true)
        {
            yield return null;
            if(gameObject.layer == 8)
            {
                gameObject.tag = "Uninfect";
                spriteRenderer.color = Color.white;
                City_Damage.Disaster_Count = 0;
            }
            else if(gameObject.layer == 9)
            {
                gameObject.tag = "Infect";
                spriteRenderer.color = Color.red;
            }
            else if(gameObject.layer == 10)
            {
                gameObject.tag = "Taken";
                spriteRenderer.color = Color.blue;
                City_Damage.Disaster_Count = 0;
            }
        }
    }
}
