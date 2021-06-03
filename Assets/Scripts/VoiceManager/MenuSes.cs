using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSes : MonoBehaviour
{
    public AudioSource source;
    public AudioClip sesclip;
    AyarlarManager ayarlarManager;
    private void Awake()
    {
        ayarlarManager = FindObjectOfType<AyarlarManager>();
        // Which AudioSource to use is set in the uýnity interface.
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void týklmasesi()
    {
         source.PlayOneShot(sesclip, 2);
    }
}
