using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using System;


public class GameManager : MonoBehaviour
{

 
    // Start is called before the first frame update



    private InterstitialAd interstitial;
   
    public int record = 0 ;
    
    //contador para ejecutar la publicidad
    public int contador = 0;
   
    public static GameManager roof;
    // Start is called before the first frame update
   private void RequestInterstitial()
    {   
         
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

        

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder()
            .Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
   void Awake()
   {
       if(roof==null){
           roof = this;
       }
       else if(roof!=null){
           Destroy(gameObject);
       }

       record = PlayerPrefs.GetInt("Record");
       contador = PlayerPrefs.GetInt("Contador");
    
       
   }
   
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestInterstitial();


        this.interstitial.OnAdClosed += HandleOnAdClosed;

        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        
    }

    // Update is called once per frame
    
    public void Record(int a){
        record = a;
        PlayerPrefs.SetInt("Record",record);
    }

    // Event for when the ad is closed
    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
        SceneManager.LoadScene("SampleScene");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Contador(int a){
        contador = contador + a;
        PlayerPrefs.SetInt("Contador",contador);

        if(contador == 4){
            contador = 1;
            PlayerPrefs.SetInt("Contador",contador);
            Debug.Log("publicidad xd");
            if (this.interstitial.IsLoaded()) {
                Debug.Log("prueba");
                this.interstitial.Show();
                
            }else{
                SceneManager.LoadScene("SampleScene");
            }
            
        }else{
            SceneManager.LoadScene("SampleScene");
        }

        if(contador>=4){
            contador = 1;
        }
    }

    
}
