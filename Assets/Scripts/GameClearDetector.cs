using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClearDetector : MonoBehaviour
{
    public GameController gameController;
    public TimeController timeController;

    bool gameClearFlag;
    // AudioSource clearSound;
    public AudioClip SE;

    public bool GameClear()
    {
        return gameClearFlag;
    }

    private void Start()
    {
        gameClearFlag = false;
        // clearSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            // clearSound.Play();
            this.GetComponent<AudioSource>().PlayOneShot(SE);
            gameClearFlag = true;
            Time.timeScale = 0f;
            gameController.SelectGameClearDescription();
            timeController.TimeShow();
        }
    }
}
