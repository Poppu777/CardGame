using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private Image cardImage;

    private CardData cardData;

    public void SetCard(CardData card)
    {
        cardData = card;
        cardImage.sprite = card.sprite;
    }

    public void OnClick()
    {
        Debug.Log("カードクリック");

        if (cardData == null)
        {
            Debug.Log("カードデータがありません");
            return;
        }



        Debug.Log(cardData.sprite);

        BattleManager.Instance.PlayCard(cardData);

        Destroy(gameObject);
    }
}