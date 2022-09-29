using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audioSource;
   [SerializeField] AudioClip[] audioList;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }
    public void FireAndExplosion(int play,float volume=1f)// default deðer verilerek kullanýlmadýoðý zaman volume 1'dir.
    {
        audioSource.PlayOneShot(audioList[play],volume);
    }
    //public void AsteroidExplosion()
    //{
    //    audioSource.PlayOneShot(audioList[1]);
    //}
    //public void PlaneExplosion()
    //{
    //    audioSource.PlayOneShot(audioList[2]);
    //}

}
