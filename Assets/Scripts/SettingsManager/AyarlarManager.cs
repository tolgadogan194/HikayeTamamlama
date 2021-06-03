using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarManager : MonoBehaviour
{

    SeviyelerManager seviyelerManager;
    MenuManager menuManager;
    private void Awake()
    {
        menuManager = FindObjectOfType<MenuManager>();
        seviyelerManager = FindObjectOfType<SeviyelerManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void menuyedongerý()
    {
        SceneManager.LoadScene("MenuScenes");
    }
 

}
