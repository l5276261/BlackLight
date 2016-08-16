using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

	public GameObject ButtonContains;
	public GameObject Tip;

	void Update()
	{
		if(Input.GetMouseButtonDown(0) && !ButtonContains.gameObject.activeInHierarchy)
		{
			ShowButton ();
		}
	}

	public void ShowButton()
	{
		ButtonContains.gameObject.SetActive (true);
		Tip.gameObject.SetActive (false);
	}

	public void ClickedNewGameButton()
	{
		PlayerPrefs.SetInt ("InputFromNewScene", 1);
	}

	public void ClickedLoadGameButton()
	{
		PlayerPrefs.SetInt ("InputFromNewScene", 0);
	}
}
