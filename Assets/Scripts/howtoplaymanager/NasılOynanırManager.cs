using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class NasılOynanırManager : MonoBehaviour
{
    

    [SerializeField]
    private GameObject panel1,panel2;
    MenuManager menuManager;
    private void Awake()
    {
        menuManager = FindObjectOfType<MenuManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GeriDonMenuye()
    {
        menuManager.VoiceSceneGo("MenuScenes");
    }
    public void ikincisayfayagit()
    {
        panel1.GetComponent<RectTransform>().DOLocalMoveX(-1236, 1f).SetEase(Ease.OutBack);
        panel2.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
    }
    public void birincisayfayagel()
    {
        panel1.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        panel2.GetComponent<RectTransform>().DOLocalMoveX(-1236, 1f).SetEase(Ease.OutBack);
    }

}
