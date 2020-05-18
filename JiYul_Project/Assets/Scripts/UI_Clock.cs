using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Clock : MonoBehaviour
{
    [SerializeField] private GameObject obj_HourHand;
    void Update()
    {
        obj_HourHand.transform.Rotate(new Vector3(0, 0, -30 * LevelManager.Instance.HoutPerSecond) * Time.deltaTime);
        int currentHour = LevelManager.Instance.CurrentHour;
        if (currentHour == 6) //아침
        {
            ChangeColor(Color.white, Color.black);
        }
        else if (currentHour == 18)
        {
            ChangeColor(Color.black, Color.white);
        }

    }

    private void ChangeColor(Color bgColor, Color otherColor)
    {
        Image[] images = GetComponentsInChildren<Image>();
        foreach(Image image in images)
        {
            StartCoroutine(Change(image, otherColor));
        }
        StartCoroutine(Change(GetComponent<Image>(), bgColor));
    }

    IEnumerator Change(Image image, Color nextColor)
    {
        if(nextColor == Color.white)
        {
            float temp = image.color.r;
            while(temp <= 1)
            {
                temp += Time.deltaTime;
                image.color = new Color(temp, temp, temp);
                yield return null;
            }
        }
        else if (nextColor == Color.black)
        {
            float temp = image.color.r;
            while (temp >= 0)
            {
                temp -= Time.deltaTime;
                image.color = new Color(temp, temp, temp);
                yield return null;
            }
        }
    }
}
