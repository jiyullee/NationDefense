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
    [SerializeField] Image timeObj;
    [SerializeField] Text roundText;
    private void Update()
    {
        if (!LevelManager.Instance.IsRound)
        {
            timeObj.gameObject.SetActive(true);
            timeObj.fillAmount = LevelManager.Instance.CurrentWaitRoundTime / LevelManager.Instance.TotalWaitRoundTime;
        }
        else
        {
            timeObj.gameObject.SetActive(false);
        }

    }

    public void SetRoundText(int round)
    {
        roundText.text = round.ToString();
    }
}
