﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	public void LoadNextScene()
	{
		SceneManager.LoadScene(1);
	}
	
	public void LoadMainMenu()
	{
		SceneManager.LoadScene(0);
	}
}
