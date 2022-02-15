using UnityEngine;

public class BallPrefab : MonoBehaviour
{
    public float speed = 600.0f;
    
    public AudioClip noise;

    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(1,0,1) * -speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name is "Left Paddle" or "Right Paddle")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = noise;
            audioSource.Play();        
        }
    }
}
