using UnityEngine;
using UnityEngine.Video;

namespace Cat
{
    public class VideoManager : MonoBehaviour
    {
        public GameObject videoPanel;

        public VideoPlayer videoPlayer;
        public VideoClip[] clips;

        private void Start()
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true);

            var clip = isHappy ? clips[0] : clips[1];

            videoPlayer.clip = clip;
            videoPlayer.Play();
        }

    }
}
