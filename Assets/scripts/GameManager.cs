using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour
{
    public Rigidbody2D MyCharacter;

#if UNITY_IOS
    private string gameId = "3988310";
#elif UNITY_ANDROID
    private string gameId= "3988311";
#endif
    [SerializeField] bool _testMode = true;

    private void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(MyCharacter.position);
        if (pos.x < 0.0) Debug.Log("I am left of the camera's view.");
        if (1.0 < pos.x) Debug.Log("I am right of the camera's view.");
        if (pos.y < 0.0)
        {
            InitializeAds();
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            Debug.Log("I am below the camera's view.");
        }
        if (1.0 < pos.y) Debug.Log("I am above the camera's view.");
    }

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
