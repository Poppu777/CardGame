using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [Header("山札")]
    public List<CardData> deck = new List<CardData>();

    private void Awake()
    {
        Shuffle();
    }

    // 山札をシャッフル
    public void Shuffle()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            int randomIndex = Random.Range(i, deck.Count);

            CardData temp = deck[i];
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    // 山札から1枚引く
    public CardData DrawCard()
    {
        if (deck.Count == 0)
            return null;

        CardData card = deck[0];
        deck.RemoveAt(0);

        return card;
    }

    // 残り枚数
    public int GetDeckCount()
    {
        return deck.Count;
    }
}