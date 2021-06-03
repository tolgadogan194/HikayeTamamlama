using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class OyunManager : MonoBehaviour
{
    [SerializeField]
    private Transform ikincipanel;
    [SerializeField]
    private GameObject pausepanel;
    public static int sorulansorussay�s� = 0;
    [SerializeField]
    private Text OnePanelText, TwoPanelText,QuestionNumberText, SoruSay�s�text;
    [SerializeField]
    string[] hikayeilkparca = new string[]
    {
        "1.)Bir bara giren iki adam ayn� i�kiyi isterler. ��kilerin t�m malzemeleri ve �l��s� birebir ayn�d�r. �lk adam gelir gelmez h�zla i�kisini i�er. Di�er adam i�kisini yava� yava� i�er. ��kisini yava� i�en adam �l�r.  ��kisini hemen i�en adama hi�bir �ey olmaz. Neden?",
        "2.)Mr. Black�in evi apartman�n 30. kat�ndad�r.  Her sabah evinden ��kar ve asans�rde zemin kat�n d��mesine basarak zemin kata iner. Her ak�am i�inden eve geldi�inde asans�rde 15. kata basar, 15. katta asans�rden iner ve y�r�yerek evine ��kar.  Ya�mur ya�d��� g�nlerde ise ak�am evine d�nd���nde 30. kata basar ve direkt evinin oldu�u 30.kata ��kar. Neden?",
        "3.)Adam pencerenin �n�nden h�zla ge�er.  Telefon sesi duyar. ���l�k atar ve �l�r.",
    };
    [SerializeField]
    string[] hikayeikinicparca = new string[]
    {
        "1.)��kilerdeki buzlarda zehir vard�r. Buzlar erimeden, h�zla i�en adama bir �ey olmaz.",
        "2.)Mr. Black c�cedir. Boyu ancak 15. kat�n d��mesine yeti�ebilmektedir. Ya�mur yand��� g�nlerde ise yan�nda �emsiye vard�r. �emsiyeyi uzatarak d��meye basar.",
        "3.)D�nyada n�kleer sava� ��kar.  T�m insanlar �l�r. Bizim hik�yedeki adam �lmez. Uzun bir s�re kendi d���nda ya�ayan birisini arar.  Yaln�zl���n keyfin ��kar�r. Sonunda s�k�l�r, bunal�ma girer ve kendini y�ksek bir apartmandan a�a��ya b�rak�r. A�a��ya d��erken, �n�nden ge�ti�i evlerin birinin penceresinden telefon sesi duyar. Yaln�z olmad���n� anlar. Art�k �ok ge�tir, �aresizlik ile ���l�k atar ve �l�r.",
    };
    SeviyelerManager seviyelerManager;
    SureMananager sureMananager;
    MenuManager menuManager;
    MenuSes menuSes;
    private void Awake()
    {
        menuSes = FindObjectOfType<MenuSes>();
        menuManager = FindObjectOfType<MenuManager>();
        seviyelerManager = FindObjectOfType<SeviyelerManager>();
        sureMananager = FindObjectOfType<SureMananager>();
    }
    public void soruvecevaplar�yerlest�r()
    {
        OnePanelText.text = hikayeilkparca[SeviyelerManager.kac�nc�hikaye - 1];
        TwoPanelText.text = hikayeikinicparca[SeviyelerManager.kac�nc�hikaye - 1];
        QuestionNumberText.text = SeviyelerManager.kac�nc�hikaye.ToString();
    }
    public void sorulansorusay�s�bagla()
    {
        sorulansorussay�s�++;
        SoruSay�s�text.text = sorulansorussay�s�.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        soruvecevaplar�yerlest�r();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SeviyelereGeridon()
    {
        SceneManager.LoadScene("MenuScenes");
        SureMananager.kalansure=0;
        SureMananager.timerActive = false;
    }
    public void ikincipanelyukar�()
    {
        ikincipanel.GetComponent<RectTransform>().DOLocalMoveY(-182, 1f).SetEase(Ease.OutBack);
    }
    public void ikincipanelasag�()
    {
        ikincipanel.GetComponent<RectTransform>().DOLocalMoveY(-2289, 1f).SetEase(Ease.OutBack);
    }
    public void Pausepaneliac()
    {
        pausepanel.SetActive(true);
        SureMananager.timerActive = false;

    }
    public void DevamEtPausePanel()
    {
        pausepanel.SetActive(false);
        SureMananager.timerActive = true;

    }
    public void AnaMenudon()
    {
        SceneManager.LoadScene("MenuScenes");
        SureMananager.timerActive = false;
    }
    public void SeviyelereDon()
    {
        SceneManager.LoadScene("SeviyelerScene");
        SureMananager.timerActive = false;
        SureMananager.kalansure = 0;
    }
    public void AyarlarDon()
    {
        SceneManager.LoadScene("AyarlarScene");
        SureMananager.timerActive = false;
    }
    public void C�k�s()
    {
        Application.Quit();
        SureMananager.timerActive = false;
    }


    public void YenidenBaslat()
    {
        
        SureMananager.kalansure = 0;
        sorulansorussay�s�=0;
        SoruSay�s�text.text = sorulansorussay�s�.ToString();
        pausepanel.SetActive(false);
        SureMananager.timerActive = true;
    }

}
