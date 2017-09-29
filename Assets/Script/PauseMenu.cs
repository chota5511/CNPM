using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public string Option;
    public GameObject Pause;
    public bool isPaused;

	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            Pause.SetActive(true);
        }
        else Pause.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused == true)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;
    }
    public void pause()
    {
        isPaused = !isPaused;
    }

    public void Resume()
    {
        isPaused = false;
    }


    public void OptionChose()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
