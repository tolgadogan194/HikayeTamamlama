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
            menuSes.t�klmasesi();
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(Scene);
        }
        StartCoroutine(araverroutine());
    }
    IEnumerator c�k�ssesi()
    {
        menuSes.t�klmasesi();
        yield return new WaitForSeconds(0.6f);
    }

    public void SeviyelerSahnesinegit()
    {
        VoiceSceneGo("SeviyelerScene");
    }
    public void AyarlarSahnesinegit()
    {
        VoiceSceneGo("AyarlarScene");
    }public void Nas�lOynan�rsahnesinegit()
    {
        VoiceSceneGo("Nas�lOyna�rScene");
    }
    public void oyundanc�k�s()
    {
        StartCoroutine(c�k�ssesi());
        Application.Quit();
    }
    public void BaslatileSeviyeleredon()
    {
        VoiceSceneGo("SeviyelerScene");
    }

}
