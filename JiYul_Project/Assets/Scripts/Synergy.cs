using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using CodeMonkey.Utils;
public class Synergy : MonoBehaviour
{
    [SerializeField] private string synergyName;
    private GameObject obj_SynergyInfo;
    [SerializeField] private int index;
    [SerializeField] private Text synergyCountText;
    [SerializeField] private int[] synergyCount;
    private City[] cities;
    private Image image_Box;
    private void Awake()
    {
        obj_SynergyInfo = transform.Find("SynergyInfo").gameObject;
        cities = FindObjectsOfType<City>();
        image_Box = transform.Find("Image").GetComponent<Image>();
    }

    private void Update()
    {
        SetSynergyCountText();
    }
    
    private void SetSynergyCountText()
    {
        int currentCount = SynergyManager.Instance.Count[index];
        if (currentCount < synergyCount[0])
        {
            image_Box.color = new Color(1, 1, 1, 0);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[0].ToString();
        }
        else if (currentCount == synergyCount[0])
        {
            image_Box.color = new Color(1, 1, 1, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[0].ToString();
        }
        else if (synergyCount[0] < currentCount && currentCount < synergyCount[1])
        {
            image_Box.color = new Color(1, 1, 1, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[1].ToString();
        }
        else if (currentCount == synergyCount[1])
        {
            image_Box.color = new Color(0, 0.5f, 1, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[1].ToString();
        }
        else if (synergyCount[1] < currentCount && currentCount < synergyCount[2])
        {
            image_Box.color = new Color(0, 0.5f, 1, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[2].ToString();
        }
        else if (currentCount == synergyCount[2])
        {
            image_Box.color = new Color(1, 0, 0, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[2].ToString();
        }
        else if (synergyCount[2] < currentCount && currentCount < synergyCount[3])
        {
            image_Box.color = new Color(1, 0, 0, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[3].ToString();
        }
        else if (currentCount == synergyCount[3])
        {
            image_Box.color = new Color(0.7411765f, 0.6666667f, 0.1333333f, 1);
            synergyCountText.text = currentCount.ToString() + "/" + synergyCount[3].ToString();
        }
    }

    public void ShowSynergyInfo()
    {
        SynergyManager.Instance.HideAllSynergyInfo();
        obj_SynergyInfo.SetActive(true);
        obj_SynergyInfo.transform.position = SynergyManager.Instance.gameObject.transform.position + new Vector3(200, 120, 0);

        foreach(City city in cities)
        {
            if(city.StateName == synergyName)
            {
                city.SelectedSynergy();
            }
        }
    }

    public void HideSynergyInfo()
    {
        obj_SynergyInfo.SetActive(false);

        foreach (City city in cities)
        {
            if (city.StateName == synergyName)
            {
                city.UnSelectedSynergy();
            }
        }
    }

    
}
