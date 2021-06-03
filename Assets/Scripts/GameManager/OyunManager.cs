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
    public static int sorulansorussayýsý = 0;
    [SerializeField]
    private Text OnePanelText, TwoPanelText,QuestionNumberText, SoruSayýsýtext;
    [SerializeField]
    string[] hikayeilkparca = new string[]
    {
        "1.)Bir bara giren iki adam ayný içkiyi isterler. Ýçkilerin tüm malzemeleri ve ölçüsü birebir aynýdýr. Ýlk adam gelir gelmez hýzla içkisini içer. Diðer adam içkisini yavaþ yavaþ içer. Ýçkisini yavaþ içen adam ölür.  Ýçkisini hemen içen adama hiçbir þey olmaz. Neden?",
        "2.)Mr. Black’in evi apartmanýn 30. katýndadýr.  Her sabah evinden çýkar ve asansörde zemin katýn düðmesine basarak zemin kata iner. Her akþam iþinden eve geldiðinde asansörde 15. kata basar, 15. katta asansörden iner ve yürüyerek evine çýkar.  Yaðmur yaðdýðý günlerde ise akþam evine döndüðünde 30. kata basar ve direkt evinin olduðu 30.kata çýkar. Neden?",
        "3.)Adam pencerenin önünden hýzla geçer.  Telefon sesi duyar. Çýðlýk atar ve ölür.",
    };
    [SerializeField]
    string[] hikayeikinicparca = new string[]
    {
        "1.)Ýçkilerdeki buzlarda zehir vardýr. Buzlar erimeden, hýzla içen adama bir þey olmaz.",
        "2.)Mr. Black cücedir. Boyu ancak 15. katýn düðmesine yetiþebilmektedir. Yaðmur yandýðý günlerde ise yanýnda þemsiye vardýr. Þemsiyeyi uzatarak düðmeye basar.",
        "3.)Dünyada nükleer savaþ çýkar.  Tüm insanlar ölür. Bizim hikâyedeki adam ölmez. Uzun bir süre kendi dýþýnda yaþayan birisini arar.  Yalnýzlýðýn keyfin çýkarýr. Sonunda sýkýlýr, bunalýma girer ve kendini yüksek bir apartmandan aþaðýya býrakýr. Aþaðýya düþerken, önünden geçtiði evlerin birinin penceresinden telefon sesi duyar. Yalnýz olmadýðýný anlar. Artýk çok geçtir, çaresizlik ile çýðlýk atar ve ölür.",
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
    public void soruvecevaplarýyerlestýr()
    {
        OnePanelText.text = hikayeilkparca[SeviyelerManager.kacýncýhikaye - 1];
        TwoPanelText.text = hikayeikinicparca[SeviyelerManager.kacýncýhikaye - 1];
        QuestionNumberText.text = SeviyelerManager.kacýncýhikaye.ToString();
    }
    public void sorulansorusayýsýbagla()
    {
        sorulansorussayýsý++;
        SoruSayýsýtext.text = sorulansorussayýsý.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        soruvecevaplarýyerlestýr();
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
    public void ikincipanelyukarý()
    {
        ikincipanel.GetComponent<RectTransform>().DOLocalMoveY(-182, 1f).SetEase(Ease.OutBack);
    }
    public void ikincipanelasagý()
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
    public void Cýkýs()
    {
        Application.Quit();
        SureMananager.timerActive = false;
    }


    public void YenidenBaslat()
    {
        
        SureMananager.kalansure = 0;
        sorulansorussayýsý=0;
        SoruSayýsýtext.text = sorulansorussayýsý.ToString();
        pausepanel.SetActive(false);
        SureMananager.timerActive = true;
    }

}
