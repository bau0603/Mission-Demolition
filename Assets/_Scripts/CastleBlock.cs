using UnityEngine;

public class CastleBlock : MonoBehaviour
{
    [Header("Set in Editor")]
    public AudioClip[] breakSounds;


    void Start()
    {
        Sleep();
    }
    
    public void Sleep()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) rb.Sleep();
    }

    void OnCollisionEnter(Collision coll)
    {
        // Play an impact sound
        if (coll.impulse.magnitude > 2f)
        {
            int i = Random.Range(0, breakSounds.Length);
            AudioSource.PlayClipAtPoint(breakSounds[i], transform.position);
        }

        // If force very high, destroy
        if (coll.impulse.magnitude > 18f)
        {
            Destroy(gameObject);
        }
    }
}