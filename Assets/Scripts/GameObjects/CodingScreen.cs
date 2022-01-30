using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CodingScreen : MonoBehaviour
{
    VideoPlayer vidPlayer;
    const int MAX_FRAMES = 30;
    const int MAX_SECONDS = 30;
    int frameCount = 0;
    int playCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        vidPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Show the frameCount - shouldn't exceed 30 and should make the text stop at the max frames
        //Debug.Log(frameCount);

        // If a mouse button is pressed, don't continue - it doesn't count as input
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            return;
        }

        // If the mouse button wasn't down, then we can process for keystrokes
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

        // If a key isn't paused, then we need to pause the code on the screen
        else
        {
            vidPlayer.Pause();
            // If we've hit the max frames, let's reset them and make any keys being pressed
            // no longer count as being pressed (ResetInputAxes)
            if (frameCount >= MAX_FRAMES)
            {
                frameCount = 0;
                Input.ResetInputAxes();
            }
        }

        vidPlayer.loopPointReached += IncreaseCount;
    }

    public void IncreaseCount(VideoPlayer vp)
    {
        playCount += 1;
    }

    IEnumerator Timer()
    {
        for (int i = 0; i<MAX_SECONDS; i++)
        {
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Time's Up!");
        GoToResult();
    }

    void GoToResult()
    {
        GameManager.Instance.ShowResult(playCount);
    }
}
