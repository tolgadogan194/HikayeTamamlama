using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeviyelerManager : MonoBehaviour
{
    public static int kac�nc�hikaye;
    public int kac�nc�bolumdey�m;
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
            kare.transform.GetComponent<Button>().onClick.AddListener(() => buttonabas�ld�());
            karelerdizisi[i] = kare;//olu�turdu�umuz kareyi kareler dizisine at�yoruz 
        }
        buttontextdegistir();
        StartCoroutine(DoFadeRoutine());

    }
    IEnumerator DoFadeRoutine()
    {
        foreach (var karean�masyon in karelerdizisi)
        {
            //yield return new WaitForSeconds(0.01f);
            karean�masyon.GetComponent<CanvasGroup>().DOFade(1, 1f);
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
    
    public void buttonabas�ld�()
    {
        //menuManager.t�klamasesi();
        SureMananager.kalansure=0;
        SureMananager.timerActive = true;

        string buttontexti = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        deger = Convert.ToInt32(buttontexti);

        //if (kac�nc�bolumdey�m >= deger)                                                                                       ---
        //{                                                                                                                     ---
            //Debug.Log(deger.ToString()+" Button no");                                                                         ---
            //Debug.Log(kac�nc�bolumdey�m.ToString()+ "b�l�m");                                                                 ---
            //if (kac�nc�bolumdey�m == deger)                                                                                   ---=====>"This code can be used if the lock system is to be fetched."
            //{                                                                                                                 ---
            //    kac�nc�bolumdey�m++;                                                                                          ---
            //    PlayerPrefs.SetInt("kac�nc�bolumdey�m", kac�nc�bolumdey�m);//PlayerPrefs used in the registration process.//  --- 
            //}                                                                                                                 ---
        if (deger == 1)
        {
            kac�nc�hikaye = 1;
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 2)        
        {                           
            kac�nc�hikaye = 2;

            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 3)        
        {                           
            kac�nc�hikaye = 3;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 4)        
        {                           
            kac�nc�hikaye = 4;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 5)       
        {                          
            kac�nc�hikaye = 5;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 6)        
        {                           
            kac�nc�hikaye = 6;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 7)        
        {                           
            kac�nc�hikaye = 7;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 8)        
        {                           
            kac�nc�hikaye = 8;      
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 9)        
        {                           
            kac�nc�hikaye = 9;      
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 10)      
        {                          
            kac�nc�hikaye = 10;    
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 11)       
        {                           
            kac�nc�hikaye = 11;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 12)       
        {                           
            kac�nc�hikaye = 12;
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 13)      
        {                          
            kac�nc�hikaye = 13;    
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 14)     
        {                         
            kac�nc�hikaye = 14;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 15)       
        {                           
            kac�nc�hikaye = 15;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 16)       
        {                           
            kac�nc�hikaye = 16;     
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 17)       
        {                           
            kac�nc�hikaye = 17;     
            SceneManager.LoadScene("OyunSahnesi");
        }                         
        else if (deger == 18)     
        {                         
            kac�nc�hikaye = 18;   
            SceneManager.LoadScene("OyunSahnesi");
        }                           
        else if (deger == 19)       
        {                           
            kac�nc�hikaye = 19;     
            SceneManager.LoadScene("OyunSahnesi");
        }                          
        else if (deger == 20)      
        {                          
            kac�nc�hikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        else if (deger == 21)      
        {                          
            kac�nc�hikaye = 21;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 22)      
        {                          
            kac�nc�hikaye = 22;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 23)      
        {                          
            kac�nc�hikaye = 23;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 24)      
        {                          
            kac�nc�hikaye = 24;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 25)      
        {                          
            kac�nc�hikaye = 25;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 26)      
        {                          
            kac�nc�hikaye = 26;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 27)      
        {                          
            kac�nc�hikaye = 27;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 28)      
        {                          
            kac�nc�hikaye = 28;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 29)      
        {                          
            kac�nc�hikaye = 29;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 30)      
        {                          
            kac�nc�hikaye = 30;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 31)      
        {                          
            kac�nc�hikaye = 31;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 32)      
        {                          
            kac�nc�hikaye = 32;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 33)      
        {                          
            kac�nc�hikaye = 33;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 34)      
        {                          
            kac�nc�hikaye = 34;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 20)      
        {                          
            kac�nc�hikaye = 20;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 35)      
        {                          
            kac�nc�hikaye = 35;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 36)      
        {                          
            kac�nc�hikaye = 36;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 37)      
        {                          
            kac�nc�hikaye = 37;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 38)      
        {                          
            kac�nc�hikaye = 38;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 39)      
        {                          
            kac�nc�hikaye = 39;    
            SceneManager.LoadScene("OyunSahnesi");
        }else if (deger == 40)      
        {                          
            kac�nc�hikaye = 40;    
            SceneManager.LoadScene("OyunSahnesi");
        }
        //}
    }
}
