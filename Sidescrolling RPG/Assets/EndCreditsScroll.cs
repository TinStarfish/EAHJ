using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCreditsScroll : MonoBehaviour {

    public float speed = 1f;
    public float timeToWait = 1f;
    public string sceneToLoad;

    public AudioSource music;

    private void Start()
    {
        StartCoroutine(CountdownTimer());
        StartCoroutine(MusicTurnDown());

    }

    void FixedUpdate () {

        transform.Translate(0, speed, 0);
       

    }

    IEnumerator CountdownTimer()
    {

        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(sceneToLoad);

    }

    IEnumerator MusicTurnDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if(music.volume>.0015)
            music.volume -= .0015f;

        }
       

    }
}
