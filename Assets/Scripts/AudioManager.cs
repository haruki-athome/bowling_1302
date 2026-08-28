using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	[SerializeField] private AudioSource ambientSource;
	[SerializeField] private AudioClip ambientClip;

	[SerializeField] private AudioSource sfxSource; 
	[SerializeField] private AudioClip HitClip;
	[SerializeField] private AudioClip WinClip;
	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject);

		ambientSource.clip = ambientClip;
		ambientSource.loop = true;
		ambientSource.Play();
	}

	public void PlayPinHit() => sfxSource.PlayOneShot(HitClip,0.5f);

}