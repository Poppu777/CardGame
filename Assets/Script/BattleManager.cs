using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;

    [SerializeField] private Image playerBattleCard;
    [SerializeField] private Image cpuBattleCard;

    [SerializeField] private CPUManager cpuManager;

    private void Awake()
    {
        Instance = this;
    }

    // プレイヤーがカードを出した時
    public void PlayCard(CardData playerCard)
    {
        Debug.Log(playerCard.sprite);

        // プレイヤーのカードを表示
        playerBattleCard.gameObject.SetActive(true);
        playerBattleCard.sprite = playerCard.sprite;

        
        // CPUがカードを出す
        Debug.Log(cpuManager);
        CardData cpuCard = cpuManager.PlayRandomCard();

        if (cpuCard != null)
        {
            Debug.Log("playerCardがnull");
            return;

        }

        Debug.Log("番号：" + playerCard.number);
        Debug.Log("Sprite：" + playerCard.sprite);


        cpuBattleCard.gameObject.SetActive(true);
        cpuBattleCard.sprite = cpuCard.sprite;
    }
}