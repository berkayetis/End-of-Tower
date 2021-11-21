using UnityEngine;
using UnityEngine.Advertisements;

public class AdsControl : MonoBehaviour
{
#if UNITY_IOS
    private string gameId="3988310";
#elif UNITY_ANDROID
    private string gameId= "3988311";
#endif
    [SerializeField] bool _testMode = true;

    void Start()
    {
        Advertisement.Initialize("3988310", _testMode);
    }

    public void InitializeAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            Debug.Log("reklamlar yuklendi.");

        }
        else
        {
            Debug.Log("reklamlar yuklenemedi.");
        }
    }
}

