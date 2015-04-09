using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

	public void LoadLevel (string name)
	{
		Debug.Log ("Hello I got here, WHATS THIS NAME? " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest ()
	{
		Debug.Log ("Are you sure?");
		Application.Quit ();
	}

}
