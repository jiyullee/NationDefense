using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Situation : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    void Start()
    {
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
            }
        }
    }
}
