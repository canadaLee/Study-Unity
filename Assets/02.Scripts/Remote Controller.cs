using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    private VideoPlayer vp;
    public VideoClip[] clips;

    public int currentClipIndex = 0;

    public bool isOn = false;
    public bool isMute = false;

    private void Awake()
    {
        vp = videoScreen.GetComponent<VideoPlayer>();
        vp.clip = clips[0];
    }

    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {
        isOn = !isOn;
        videoScreen.SetActive(isOn);
    }

    public void OnMute()
    {
        isMute = !isMute;
        vp.SetDirectAudioMute(0, isMute);
    }

    public void OnPrevChannel()
    {
        currentClipIndex--;
        if (currentClipIndex < 0)
            currentClipIndex = 2;

        vp.clip = clips[currentClipIndex];
        vp.Play();
    }
    public void OnNextChannel()
    {
        currentClipIndex++;

        if (currentClipIndex >2)
            currentClipIndex = 0;

        vp.clip = clips[currentClipIndex];
        vp.Play();
    }
}
