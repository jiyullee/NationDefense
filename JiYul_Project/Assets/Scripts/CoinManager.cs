using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private static CoinManager instance;
    public static CoinManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CoinManager>();
            }
            return instance;
        }
    }

    public int Gold { get => gold; set => gold = value; }

    [SerializeField] private int gold;

    public void IncreaseGold(int n)
    {
        gold += n;
        CanvasManager.Instance.SetCoinText(gold);
    }
}
