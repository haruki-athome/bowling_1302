using UnityEngine;

public class Pin : MonoBehaviour
{
	private bool hasBeenHit = false;

	private void OnCollisionEnter(Collision collision)
	{
		if (hasBeenHit) return;

		Bowling ball = collision.gameObject.GetComponent<Bowling>();
		if (ball == null)
			return;

		hasBeenHit = true;
		AudioManager.instance.PlayPinHit();
	}
}