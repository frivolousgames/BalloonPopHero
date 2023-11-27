using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GoogleMobileAds.Api;

public class AdController : MonoBehaviour
{
    /*private BannerView bannerView;

    private void Awake()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-9371090989425447~5880270036";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-9371090989425447~3367100410";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
    }

    public void Start()
    {

        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-9371090989425447/1941025029";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-9371090989425447/8946730150";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("805F12446CDF496B").Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);

        


    }
    private void Update()
    {

        this.bannerView.Show();
    }
    */
}
