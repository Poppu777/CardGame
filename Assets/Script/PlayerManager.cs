using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("山札")]
    [SerializeField] private DeckManager deckManager;

    [Header("カードプレハブ")]
    [SerializeField] private GameObject cardPrefab;

    [Header("手札を並べる場所")]
    [SerializeField] private Transform handArea;

    private List<CardData> hand = new List<CardData>();

    private void Start()
    {
        DrawStartingHand();
    }

    // 最初に5枚配る
    void DrawStartingHand()
    {
        for (int i = 0; i < 5; i++)
        {
            CardData card = deckManager.DrawCard();

            if (card != null)
            {
                hand.Add(card);

                GameObject obj = Instantiate(cardPrefab, handArea);

                CardUI cardUI = obj.GetComponent<CardUI>();

                cardUI.SetCard(card);
            }
        }
    }
}