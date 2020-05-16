using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City_CanvasManager : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameObject obj_CityInfo;

    public void OnClick_City()
    {
        SynergyManager.Instance.SetPos_OnCityUI();
        UI_CityInfo[] city_UIs = FindObjectsOfType<UI_CityInfo>();
        foreach(UI_CityInfo ui_CityInfo in city_UIs)
        {
            ui_CityInfo.gameObject.SetActive(false);
        }
        obj_CityInfo.SetActive(true);
        obj_CityInfo.GetComponent<UI_CityInfo>().SetInfo();
    }

}
