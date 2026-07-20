using System.Collections.Generic;
using UnityEngine;

public class CPUManager : MonoBehaviour
{
    [Header("山札")]
    [SerializeField] private DeckManager deckManager;

    private List<CardData> hand = new List<CardData>();

    private void Start()
    {
        DrawStartingHand();
    }


    // 最初に5枚配る
    public void DrawStartingHand()
    {
        for (int i = 0; i < 5; i++)
        {
            CardData card = deckManager.DrawCard();

            if (card != null)
            {
                hand.Add(card);
            }
        }
    }

    // ランダムに1枚出す
    public CardData PlayRandomCard()
    {
        Debug.Log("PlayRandomCardが呼ばれた");

        if (hand.Count == 0)
        {
            Debug.Log("CPUの手札が0枚です");
            return null;
        }

        int randomIndex = Random.Range(0, hand.Count);
        CardData card = hand[randomIndex];
        hand.RemoveAt(randomIndex);

        return card;
    }
}