using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class QuitHandler : MonoBehaviour
{
	void Update()
	{
		if (Keyboard.current.escapeKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("MainMenu"); // replace with your actual main menu scene name
		}
	}
}