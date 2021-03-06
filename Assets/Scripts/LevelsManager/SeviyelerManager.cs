using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeviyelerManager : MonoBehaviour
{
    public static int kacıncıhikaye;
    public int kacıncıbolumdeyım;
    public static int deger;
    [SerializeField]
    private GameObject karelevelbtnPrefab;
    [SerializeField]
    private Transform karelerinpaneli;
    private GameObject[] karelerdizisi = new GameObject[40];
    MenuManager menuManager;
    MenuSes menuSes;
    private void Awake()
    {
        menuSes = FindObjectOfType<MenuSes>();
        menuManager = FindObjectOfType<MenuManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        kareleriolustur();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void kareleriolustur()
    {
        for (int i = 0; i < karelerdizisi.Length; i++)
        {
            GameObject kare = Instantiate(karelevelbtnPrefab, karelerinpaneli);
            kare.transform.GetComponent<Button>().onClick.AddListener(() => buttonabasıldı());
            karelerdizisi[i] = kare;//oluşturduğumuz kareyi kareler dizisine atıyoruz 
        }
        buttontextdegistir();
        StartCoroutine(DoFadeRoutine());

    }
    IEnumerator DoFadeRoutine()
    {
        foreach (var kareanımasyon in karelerdizisi)
        {
            //yield return new WaitForSeconds(0.01f);
            kareanımasyon.GetComponent<CanvasGroup>().DOFade(1, 1f);
            yield return new WaitForSeconds(0.09f);
        }
    }
    public void buttontextdegistir()
    {
        int bolumno = 0;
        foreach (var karetext in karelerdizisi)
        {
            bolumno++;
            karetext.transform.GetChild(0).GetComponent<Text>().text = bolumno.ToString();
        }
    }
    public void MenuyeGeridon()
    {
        SceneManager.LoadScene("MenuScenes");
    }
    
    public void buttonabasıldı()
    {
        //menuManager.tıklamasesi();
        SureMananager.kalansure=0;
        SureMananager.timerActive = true;

        string buttontexti = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        deger = Convert.ToInt32(buttontexti);

        //if (kacıncıbolumdeyım >= deger)                                                                                       ---
        //{                                                                                                                     ---
            //Debug.Log(deger.ToString()+" Button no");                                                                         ---
            //Debug.Log(kacıncıbolumdeyım.ToString()+ "bölüm");                                                                 ---
            //if (kacıncıbolumdeyım == deger)                                                                                   ---=====>"This code can be used if the lock system is to be fetched."
            //{                                                                                                                 ---
            //    kacıncıbolumdeyım++;                                                                                          ---
            //    PlayerPrefs.SetInt("kacıncıbolumdeyım", kacıncıbolumdeyım);//PlayerPrefs used in the registration process.//  --- 
            //}                                                                                                                 ---
        if (deger == 1)
        {
            kacıncıhikaye = 1;
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 2)        
        {                           
            kacıncıhikaye = 2;

            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 3)        
        {                           
            kacıncıhikaye = 3;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 4)        
        {                           
            kacıncıhikaye = 4;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 5)       
        {                          
            kacıncıhikaye = 5;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 6)        
        {                           
            kacıncıhikaye = 6;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 7)        
        {                           
            kacıncıhikaye = 7;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 8)        
        {                           
            kacıncıhikaye = 8;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 9)        
        {                           
            kacıncıhikaye = 9;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 10)      
        {                          
            kacıncıhikaye = 10;    
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 11)       
        {                           
            kacıncıhikaye = 11;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 12)       
        {                           
            kacıncıhikaye = 12;
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 13)      
        {                          
            kacıncıhikaye = 13;    
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 14)     
        {                         
            kacıncıhikaye = 14;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 15)       
        {                           
            kacıncıhikaye = 15;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 16)       
        {                           
            kacıncıhikaye = 16;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 17)       
        {                           
            kacıncıhikaye = 17;     
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 18)     
        {                         
            kacıncıhikaye = 18;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 19)       
        {                           
            kacıncıhikaye = 19;     
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 20)      
        {                          
            kacıncıhikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        else if (deger == 21)      
        {                          
            kacıncıhikaye = 21;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 22)      
        {                          
            kacıncıhikaye = 22;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 23)      
        {                          
            kacıncıhikaye = 23;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 24)      
        {                          
            kacıncıhikaye = 24;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 25)      
        {                          
            kacıncıhikaye = 25;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 26)      
        {                          
            kacıncıhikaye = 26;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 27)      
        {                          
            kacıncıhikaye = 27;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 28)      
        {                          
            kacıncıhikaye = 28;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 29)      
        {                          
            kacıncıhikaye = 29;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 30)      
        {                          
            kacıncıhikaye = 30;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 31)      
        {                          
            kacıncıhikaye = 31;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 32)      
        {                          
            kacıncıhikaye = 32;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 33)      
        {                          
            kacıncıhikaye = 33;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 34)      
        {                          
            kacıncıhikaye = 34;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 20)      
        {                          
            kacıncıhikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 35)      
        {                          
            kacıncıhikaye = 35;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 36)      
        {                          
            kacıncıhikaye = 36;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 37)      
        {                          
            kacıncıhikaye = 37;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 38)      
        {                          
            kacıncıhikaye = 38;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 39)      
        {                          
            kacıncıhikaye = 39;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 40)      
        {                          
            kacıncıhikaye = 40;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        //}
    }
}
