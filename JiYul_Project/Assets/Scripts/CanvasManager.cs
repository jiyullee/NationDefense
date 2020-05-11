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

    public bool ChangeDayNight { get => changeDayNight; set => changeDayNight = value; }

    [SerializeField] Button roundStartBtn;
    [SerializeField] Image timeObj;
    [SerializeField] Text roundText;
    [SerializeField] Text coinText;

    private bool changeDayNight;
    private void Start()
    {
        coinText.text = CoinManager.Instance.Gold.ToString();
        roundText.text = "";
    }
    private void Update()
    {
        if (!LevelManager.Instance.IsRound)
        {
            timeObj.gameObject.SetActive(true);
            timeObj.fillAmount = LevelManager.Instance.CurrentWaitRoundTime / LevelManager.Instance.TotalWaitRoundTime;
            if( 0.49 <= timeObj.fillAmount && timeObj.fillAmount <= 0.51 && changeDayNight == false)
            {
                changeDayNight = true;
                if (timeObj.color == Color.white)
                    timeObj.color = Color.black;
                else if (timeObj.color == Color.black)
                    timeObj.color = Color.white;
            }
        }
        else
        {
            //timeObj.gameObject.SetActive(false);
        }

    }

    public void OnClick_StartRound()
    {
        LevelManager.Instance.StartDay();
    }

    public void SetRoundText(int round)
    {
        roundText.text = round.ToString();
    }

    public void SetCoinText(int coin)
    {
        coinText.text = coin.ToString();
    }
}
