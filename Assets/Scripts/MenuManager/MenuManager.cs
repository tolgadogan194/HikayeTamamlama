using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    MenuSes menuSes;
    private void Awake()
    {
        menuSes = FindObjectOfType<MenuSes>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VoiceSceneGo(string Scene)
    {
        IEnumerator araverroutine()
        {
            menuSes.tıklmasesi();
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(Scene);
        }
        StartCoroutine(araverroutine());
    }
    IEnumerator cıkıssesi()
    {
        menuSes.tıklmasesi();
        yield return new WaitForSeconds(0.6f);
    }

    public void SeviyelerSahnesinegit()
    {
        VoiceSceneGo("SeviyelerScene");
    }
    public void AyarlarSahnesinegit()
    {
        VoiceSceneGo("AyarlarScene");
    }public void NasılOynanırsahnesinegit()
    {
        VoiceSceneGo("NasılOynaırScene");
    }
    public void oyundancıkıs()
    {
        StartCoroutine(cıkıssesi());
        Application.Quit();
    }
    public void BaslatileSeviyeleredon()
    {
        VoiceSceneGo("SeviyelerScene");
    }

}
