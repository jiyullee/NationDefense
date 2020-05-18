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
    [SerializeField] private LayerMask layerMask;
    [SerializeField] Image timeImg;
    [SerializeField] Text text_Round;
    [SerializeField] Text text_Coin;
    [SerializeField] GameObject prefab_SkillRange;
    private bool changeDayNight;

    private void Start()
    {
        text_Coin.text = CoinManager.Instance.Gold.ToString();
        text_Round.text = "";
    }
    private void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, layerMask);
            if (hit.collider == null)
            {
                UI_SynergyInfo UI_SynergyInfo = FindObjectOfType<UI_SynergyInfo>();
                UI_SkillTooltip UI_SkillTooltip = FindObjectOfType<UI_SkillTooltip>();
                if (UI_SynergyInfo != null)
                {
                    float posX = Input.mousePosition.x;
                    float posY = Input.mousePosition.y;
                    if ((0 <= posX && posX <= 720) && (0 <= posY && posY <= 100))
                        return;
                    SynergyManager.Instance.HideAllSynergyInfo();
                }
                if (UI_SkillTooltip != null)
                {
                    UI_SkillTooltip.gameObject.SetActive(false);
                }
            }
        }

    }

    public void SetRoundText(int round)
    {
        text_Round.text = round.ToString();
    }

    public void SetCoinText(int coin)
    {
        text_Coin.text = coin.ToString();
    }

    public void OnSkillRange(Vector3 pos, int radius)
    {
        GameObject obj = Instantiate(prefab_SkillRange, pos, Quaternion.identity);
        obj.transform.localScale = new Vector3(100 + radius, 100 + radius, 1);
    }

}
