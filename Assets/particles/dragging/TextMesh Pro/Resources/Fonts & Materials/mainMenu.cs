﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public int playerLives;
  
    public int whichLevel;

    int i;
    public void PlayGame()
    {
        i += 3;
        NextLevel();

        //randomLevel();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

   /* public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
       
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
        
    }
    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
   
    }
    public void Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
       
    }
    public void Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
        
    }
    public void Level6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
       
    }
    public void Level7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
       
    }



    public void randomLevel()
    {
        whichLevel = Random.Range(0, 8);
            {
            if (whichLevel == 0)
            {

                Level3();
            }
            if (whichLevel == 1)
            {

                Level1();
            }
            if (whichLevel == 2)
            {

                Level2();
            }

            if (whichLevel == 3)
            {

                Level3();
            }
            if (whichLevel == 4)
            {

                Level4();
            }
            if (whichLevel == 5)
            {

                Level5();
            }
            if (whichLevel == 6)
            {

                Level6();
            }
            if (whichLevel == 7)
            {

                Level7();
            }
            if (whichLevel == 8)
            {

                Level7();
            }


        }
    }


 */   public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
