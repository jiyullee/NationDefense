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

    public void OnClick_CityUI()
    {
        cityUI.SetActive(true);
    }

    public void OnClick_DisableCityUI()
    {
        cityUI.SetActive(false);
    }
}
