using UnityEngine;
using Unity.Services.LevelPlay;
using System;

public class LevelPlayInit : MonoBehaviour
{
    public void Start()
    {
        // Register OnInitFailed and OnInitSuccess listeners
        LevelPlay.OnInitSuccess += InitCompleted;
        LevelPlay.OnInitFailed += InitFailed;
        // SDK init
        LevelPlay.Init("YourAppKey");
    }

    private void InitCompleted(LevelPlayConfiguration config)
    {
        Debug.Log("LevelPlay Initialization Complete!");

        InterstitalAdManager.Instance.CreateInterstitialAd();
        BannerAdManager.instance.CreateBannerAd();
    }

    private void InitFailed(LevelPlayInitError error)
    {
        Debug.Log($"{error.ErrorCode} LevelPlay Initialization Failed! Reason: {error.ErrorMessage}");
    }
}
