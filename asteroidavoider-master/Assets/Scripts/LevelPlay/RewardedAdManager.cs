using Unity.Services.LevelPlay;
using UnityEngine;

public class RewardedAdManager : MonoBehaviour
{
    public static RewardedAdManager instance;

    private LevelPlayRewardedAd RewardedAd;

    private void Awake()
    {
        instance = this;
    }

    public void CreateRewardedAd()
    {
        //Create RewardedAd instance
        RewardedAd = new LevelPlayRewardedAd("RewardedAdUnitId");

        //Subscribe RewardedAd events
        RewardedAd.OnAdLoaded += RewardedOnAdLoadedEvent;
        RewardedAd.OnAdLoadFailed += RewardedOnAdLoadFailedEvent;
        RewardedAd.OnAdDisplayed += RewardedOnAdDisplayedEvent;
        RewardedAd.OnAdDisplayFailed += RewardedOnAdDisplayFailedEvent;
        RewardedAd.OnAdClicked += RewardedOnAdClickedEvent;
        RewardedAd.OnAdClosed += RewardedOnAdClosedEvent;
        RewardedAd.OnAdRewarded += RewardedOnAdRewarded;
        RewardedAd.OnAdInfoChanged += RewardedOnAdInfoChangedEvent;
    }

    void LoadRewardedAd()
    {
        //Load or reload RewardedAd     
        RewardedAd.LoadAd();
    }
    void ShowRewardedAd()
    {
        //Show RewardedAd, check if the ad is ready before showing
        if (RewardedAd.IsAdReady())
        {
            RewardedAd.ShowAd();
        }
    }


    //Implement RewardedAd events
    void RewardedOnAdLoadedEvent(LevelPlayAdInfo adInfo) { }
    void RewardedOnAdLoadFailedEvent(LevelPlayAdError ironSourceError) { }
    void RewardedOnAdClickedEvent(LevelPlayAdInfo adInfo) { }
    void RewardedOnAdDisplayedEvent(LevelPlayAdInfo adInfo) { }
    void RewardedOnAdDisplayFailedEvent(LevelPlayAdInfo adInfo, LevelPlayAdError adError) { }
    void RewardedOnAdClosedEvent(LevelPlayAdInfo adInfo) { }
    void RewardedOnAdRewarded(LevelPlayAdInfo adInfo, LevelPlayReward adReward) { }
    void RewardedOnAdInfoChangedEvent(LevelPlayAdInfo adInfo) { }
}
