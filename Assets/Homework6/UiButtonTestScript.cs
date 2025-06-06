using UnityEngine;

public class UiButtonTestScript : MonoBehaviour
{
	public string _playerName = "Stefan I.";

	public void ClickOnButton()
	{
		Debug.Log("The button has been pressed by: " + _playerName);
	}
}
