using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    private static CanvasManager instance;
    public static CanvasManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CanvasManager>();
            }
            return instance;
        }
    }

    [SerializeField] Button roundStartBtn;
    [SerializeField] GameObject cityUI;

    UI_CityInfo UI_city;
    private void Awake()
    {
        UI_city = cityUI.GetComponent<UI_CityInfo>();
    }
    public void Change_CityInfo(string tag, string name, string state, int hp, int damage, int cost)
    {
        cityUI.SetActive(true);
        UI_city.ChangeCityInfo(tag, name, state, hp, damage, cost);
    }
    

    public void OnClick_DisableCityUI()
    {
        cityUI.SetActive(false);
    }
}
