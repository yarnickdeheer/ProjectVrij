using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class Sound1 : MonoBehaviour { 


public VideoPlayer player;
public VideoClip clip;
public AudioSource audioSource;
    public int scene;

// Use this for initialization
void Start()
{
    player.audioOutputMode = VideoAudioOutputMode.Direct;
    player.SetTargetAudioSource(0, audioSource);
    player.source = VideoSource.VideoClip;
    player.clip = clip;
    player.Prepare();
    player.Play();
    player.loopPointReached += finishgame;
    }
    void finishgame(VideoPlayer player)
    {
        // bf.SetActive(true);
       /// Screen.lockCursor = true;
       /// Cursor.visible = false;
        //controller.enabled = true;
        player.Stop();

        SceneManager.LoadScene(scene);
        // image.enabled = false;
        Debug.Log("done");

        //  Time.timeScale = 1;
    }
}
