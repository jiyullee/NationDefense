using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] protected string cityName;
    [SerializeField] protected Text nameText;
    [SerializeField] protected SpriteRenderer spriteRenderer;
    [SerializeField] LayerMask layerMask;

    public string GetName()
    {
        return cityName;
    }

    public void Infect_New()
    {
        spriteRenderer.color = Color.red;
        gameObject.tag = "Infect";
        gameObject.layer = 8;
    }

    public void Infect_Old()
    {
        Collider2D[] aroundCities = Physics2D.OverlapCircleAll(transform.position, 50f, layerMask);
        print(cityName + " " + aroundCities.Length);
        Random.InitState((int)(Time.time * 100f));

        if (aroundCities.Length == 0)
            return;

        int rand = Random.Range(0, aroundCities.Length);
        aroundCities[rand].gameObject.GetComponentInParent<City>().Infect_New();

    }
}
