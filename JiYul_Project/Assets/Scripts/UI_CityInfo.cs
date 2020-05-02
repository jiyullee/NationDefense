using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_CityInfo : MonoBehaviour
{
    [SerializeField] private Text stateText;
    [SerializeField] private Text nameText;
    [SerializeField] private GameObject hpObj;
    [SerializeField] private GameObject damageObj;
    [SerializeField] private Text costText;
    void Start()
    {
        
    }

    public void ChangeCityInfo(string tag, string name, string state, int hp, int damage, int cost)
    {
        if(tag == "Uninfect")
        {
            stateText.text = state;
            nameText.text = name;
            costText.text = cost.ToString();
        }
        else if(tag == "Infect")
        {
            stateText.text = state;
            nameText.text = name;
            damageObj.SetActive(true);
            damageObj.GetComponentInChildren<Text>().text = damage.ToString();
        }
        else if(tag == "Taken")
        {
            stateText.text = state;
            nameText.text = name;
            hpObj.SetActive(true);
            hpObj.GetComponentInChildren<Text>().text = damage.ToString();
        }
    }

    public void OnClick_DisableUI()
    {
        gameObject.SetActive(false);
    }
}
