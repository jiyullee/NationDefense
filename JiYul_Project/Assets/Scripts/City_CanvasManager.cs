using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City_CanvasManager : MonoBehaviour
{
    [SerializeField] City city;
    [SerializeField] Button button;
    [SerializeField] protected Text nameText;

    void Start()
    {
        nameText.text = city.GetName();
        button.onClick.AddListener(() =>
        {
            CanvasManager.Instance.OnClick_CityUI();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
