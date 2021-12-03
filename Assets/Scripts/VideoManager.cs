using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Threading;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    public GameObject MeganBox;
    public GameObject LivTyler;
    public GameObject Cantina;
    public GameObject WilfordBramley;
    public GameObject ExitCanvas;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Cube()
    {
        LivTyler.SetActive(false);
        Cantina.SetActive(false);
        WilfordBramley.SetActive(false);
        Thread.Sleep(2000);
        MeganBox.SetActive(true);
    }

    public void LivingRoom()
    {
        MeganBox.SetActive(false);
        Cantina.SetActive(false);
        WilfordBramley.SetActive(false);
        Thread.Sleep(2000);
        LivTyler.SetActive(true);
    }

    public void Mezzanine()
    {
        MeganBox.SetActive(false);
        LivTyler.SetActive(false);
        Cantina.SetActive(false);
        Thread.Sleep(2000);
        WilfordBramley.SetActive(true);
    }

    public void Trantina()
    {
        MeganBox.SetActive(false);
        LivTyler.SetActive(false);
        WilfordBramley.SetActive(false);
        Thread.Sleep(2000);
        Cantina.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (ExitCanvas.activeSelf == false)
                {
                    ExitCanvas.SetActive(true);
                }
                else
                {
                    ExitCanvas.SetActive(false);
                }
            }
    }

}
