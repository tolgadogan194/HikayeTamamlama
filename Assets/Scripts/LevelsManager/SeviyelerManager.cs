using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeviyelerManager : MonoBehaviour
{
    public static int kacýncýhikaye;
    public int kacýncýbolumdeyým;
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
            kare.transform.GetComponent<Button>().onClick.AddListener(() => buttonabasýldý());
            karelerdizisi[i] = kare;//oluþturduðumuz kareyi kareler dizisine atýyoruz 
        }
        buttontextdegistir();
        StartCoroutine(DoFadeRoutine());

    }
    IEnumerator DoFadeRoutine()
    {
        foreach (var kareanýmasyon in karelerdizisi)
        {
            //yield return new WaitForSeconds(0.01f);
            kareanýmasyon.GetComponent<CanvasGroup>().DOFade(1, 1f);
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
    
    public void buttonabasýldý()
    {
        //menuManager.týklamasesi();
        SureMananager.kalansure=0;
        SureMananager.timerActive = true;

        string buttontexti = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        deger = Convert.ToInt32(buttontexti);

        //if (kacýncýbolumdeyým >= deger)                                                                                       ---
        //{                                                                                                                     ---
            //Debug.Log(deger.ToString()+" Button no");                                                                         ---
            //Debug.Log(kacýncýbolumdeyým.ToString()+ "bölüm");                                                                 ---
            //if (kacýncýbolumdeyým == deger)                                                                                   ---=====>"This code can be used if the lock system is to be fetched."
            //{                                                                                                                 ---
            //    kacýncýbolumdeyým++;                                                                                          ---
            //    PlayerPrefs.SetInt("kacýncýbolumdeyým", kacýncýbolumdeyým);//PlayerPrefs used in the registration process.//  --- 
            //}                                                                                                                 ---
        if (deger == 1)
        {
            kacýncýhikaye = 1;
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 2)        
        {                           
            kacýncýhikaye = 2;

            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 3)        
        {                           
            kacýncýhikaye = 3;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 4)        
        {                           
            kacýncýhikaye = 4;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 5)       
        {                          
            kacýncýhikaye = 5;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 6)        
        {                           
            kacýncýhikaye = 6;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 7)        
        {                           
            kacýncýhikaye = 7;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 8)        
        {                           
            kacýncýhikaye = 8;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 9)        
        {                           
            kacýncýhikaye = 9;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 10)      
        {                          
            kacýncýhikaye = 10;    
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 11)       
        {                           
            kacýncýhikaye = 11;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 12)       
        {                           
            kacýncýhikaye = 12;
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 13)      
        {                          
            kacýncýhikaye = 13;    
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 14)     
        {                         
            kacýncýhikaye = 14;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 15)       
        {                           
            kacýncýhikaye = 15;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 16)       
        {                           
            kacýncýhikaye = 16;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 17)       
        {                           
            kacýncýhikaye = 17;     
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 18)     
        {                         
            kacýncýhikaye = 18;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 19)       
        {                           
            kacýncýhikaye = 19;     
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 20)      
        {                          
            kacýncýhikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        else if (deger == 21)      
        {                          
            kacýncýhikaye = 21;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 22)      
        {                          
            kacýncýhikaye = 22;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 23)      
        {                          
            kacýncýhikaye = 23;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 24)      
        {                          
            kacýncýhikaye = 24;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 25)      
        {                          
            kacýncýhikaye = 25;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 26)      
        {                          
            kacýncýhikaye = 26;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 27)      
        {                          
            kacýncýhikaye = 27;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 28)      
        {                          
            kacýncýhikaye = 28;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 29)      
        {                          
            kacýncýhikaye = 29;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 30)      
        {                          
            kacýncýhikaye = 30;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 31)      
        {                          
            kacýncýhikaye = 31;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 32)      
        {                          
            kacýncýhikaye = 32;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 33)      
        {                          
            kacýncýhikaye = 33;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 34)      
        {                          
            kacýncýhikaye = 34;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 20)      
        {                          
            kacýncýhikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 35)      
        {                          
            kacýncýhikaye = 35;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 36)      
        {                          
            kacýncýhikaye = 36;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 37)      
        {                          
            kacýncýhikaye = 37;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 38)      
        {                          
            kacýncýhikaye = 38;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 39)      
        {                          
            kacýncýhikaye = 39;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 40)      
        {                          
            kacýncýhikaye = 40;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        //}
    }
}
