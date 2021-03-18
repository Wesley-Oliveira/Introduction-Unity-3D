using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject gambs, background, menu, options, player, sound, optionsGame;
    public bool gameplayOn;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        gambs.SetActive(true);
        background.SetActive(true);
        menu.SetActive(true);
        options.SetActive(false);
        optionsGame.SetActive(false);
        gameplayOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gameplayOn)
            {
                player.SetActive(false);
                gambs.SetActive(true);
                background.SetActive(true);
                menu.SetActive(false);
                optionsGame.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void ExitOptionsMenu()
    {
        gambs.SetActive(true);
        background.SetActive(true);
        menu.SetActive(true);
        options.SetActive(false);
        player.SetActive(false);
    }

    public void ExitOptionsGame()
    {
        gambs.SetActive(false);
        background.SetActive(false);
        menu.SetActive(false);
        options.SetActive(false);
        player.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Sound()
    {
        if(sound.activeSelf == true)
        {
            sound.SetActive(false);
        }
        else
        {
            sound.SetActive(true);
        }
    }

    public void GoOptionsMenu()
    {
        menu.SetActive(false);
        options.SetActive(true);
        gameplayOn = false;
    }

    public void GoGameplay()
    {
        gameplayOn = true;
    }
}
