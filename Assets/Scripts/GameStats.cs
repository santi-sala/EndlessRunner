using System;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static GameStats _Instance { get { return instance; } }
    private static GameStats instance;

    // SCore
    public float score;
    public float highscore;
    public float disstanceModifier = 1.5f;

    // Coins
    public int totalCoins;
    public int currentCollectedCoins;
    public float coinPoints = 10.0f;
    public AudioClip coinSFX;

    // Internal cooldown
    private float lastScoreUpdate;
    private float scoreUpdateDelta = 0.2f;


    // Action
    public Action<int> OnCollectedCoin;
    public Action<float> OnScoreChange;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        float currentScore = GameManager._Instance.gameMotor.transform.position.z * disstanceModifier;
        currentScore += currentCollectedCoins * coinPoints;


        // Just making sure we do not lose score when triggered the dying animation as Tiago is moved backwards.
        if (currentScore > score)
        {
            score = currentScore;
            if (Time.time - lastScoreUpdate > scoreUpdateDelta)
            {
                lastScoreUpdate = Time.time;
                OnScoreChange?.Invoke(score);
            }
        }
    }

    public void CollectCoin()
    {
        currentCollectedCoins++;
        OnCollectedCoin?.Invoke(currentCollectedCoins);
        AudioManager._Instance.PlaySFX(coinSFX, 2.5f);
    }

    public void ResetSession()
    {
        score = 0;
        currentCollectedCoins = 0;

        OnCollectedCoin?.Invoke(currentCollectedCoins);
        OnScoreChange?.Invoke(score);
    }

    //public string ScoreToText()
    //{
    //    return score.ToString("0000000");
    //}

    //public string CoinsToText()
    //{
    //    return currentCollectedCoins.ToString("0000");
    //}
}
