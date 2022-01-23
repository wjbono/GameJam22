using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CodingScreen : MonoBehaviour
{
    VideoPlayer vidPlayer;
    const int MAX_FRAMES = 30;
    int frameCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        vidPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(frameCount);
        if (Input.anyKey)
        {
            if (frameCount < MAX_FRAMES)
            {
                frameCount += 1;
                vidPlayer.Play();
            }
            else
            {
                vidPlayer.Pause();
            }
        }
        else
        {
            vidPlayer.Pause();
            if (frameCount >= MAX_FRAMES)
            {
                frameCount = 0;
                Input.ResetInputAxes();
            }
        }
    }
}
