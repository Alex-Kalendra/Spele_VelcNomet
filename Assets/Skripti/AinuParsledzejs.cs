using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importé, lai varétu veikt ainu ieládi
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void UzSakumu(){
		SceneManager.LoadScene ("GameMenu", LoadSceneMode.Single);
	}

	public void UzUI()
	{
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

	public void Apturet()
	{
		Application.Quit ();
	}

}
