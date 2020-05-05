using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City_CanvasManager : MonoBehaviour
{
    City city;
    [SerializeField] Button button;
    [SerializeField] protected Text nameText;
    [SerializeField] GameObject cityInfo;

    private void Awake()
    {
        city = GetComponentInParent<City>();
    }
    void Start()
    {
        StartCoroutine(CheckDay());
    }

    IEnumerator CheckDay()
    {
        while (true)
        {
            yield return null;
            if (LevelManager.Instance.IsRound)
            {
                StartDay();
            }else
            {
                EndDay();
            }
        }
    }
    public void OnClick_City()
    {
        UI_CityInfo[] city_UIs = FindObjectsOfType<UI_CityInfo>();
        foreach(UI_CityInfo ui_CityInfo in city_UIs)
        {
            ui_CityInfo.gameObject.SetActive(false);
        }
        cityInfo.SetActive(true);
        cityInfo.GetComponent<UI_CityInfo>().SetInfo();
    }

    public void OnClick_DisableUI()
    {
        cityInfo.SetActive(false);
    }

    public void StartDay()
    {
        button.interactable = false;
    }

    public void EndDay()
    {
        button.interactable = true;
    }
}
