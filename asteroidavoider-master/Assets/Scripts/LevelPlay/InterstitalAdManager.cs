using Unity.Services.LevelPlay;
using UnityEngine;

public class InterstitalAdManager : MonoBehaviour
{
    public static InterstitalAdManager Instance;

    private LevelPlayInterstitialAd interstitialAd;

    private void Awake()
    {
        Instance = this;
    }

    public void CreateInterstitialAd()
    {
        //Create InterstitialAd instance
        interstitialAd = new LevelPlayInterstitialAd("interstitialAdUnitId");

        //Subscribe InterstitialAd events
        interstitialAd.OnAdLoaded += InterstitialOnAdLoadedEvent;
        interstitialAd.OnAdLoadFailed += InterstitialOnAdLoadFailedEvent;
        interstitialAd.OnAdDisplayed += InterstitialOnAdDisplayedEvent;
        interstitialAd.OnAdDisplayFailed += InterstitialOnAdDisplayFailedEvent;
        interstitialAd.OnAdClicked += InterstitialOnAdClickedEvent;
        interstitialAd.OnAdClosed += InterstitialOnAdClosedEvent;
        interstitialAd.OnAdInfoChanged += InterstitialOnAdInfoChangedEvent;

        LoadInterstitialAd();
    }
    void LoadInterstitialAd()
    {
        //Load or reload InterstitialAd 	
        interstitialAd.LoadAd();
    }
    public void ShowInterstitialAd()
    {
        //Show InterstitialAd, check if the ad is ready before showing
        if (interstitialAd.IsAdReady())
        {
            interstitialAd.ShowAd();
        }
    }

    //Implement InterstitialAd events
    void InterstitialOnAdLoadedEvent(LevelPlayAdInfo adInfo) { }
    void InterstitialOnAdLoadFailedEvent(LevelPlayAdError ironSourceError) { }
    void InterstitialOnAdClickedEvent(LevelPlayAdInfo adInfo) { }
    void InterstitialOnAdDisplayedEvent(LevelPlayAdInfo adInfo) { }
    void InterstitialOnAdDisplayFailedEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }
    void InterstitialOnAdClosedEvent(LevelPlayAdInfo adInfo) { }
    void InterstitialOnAdInfoChangedEvent(LevelPlayAdInfo adInfo) { }
}
