using UnityEngine;

public class WallController : MonoBehaviour
{
    private bool isHidden = false; // Flag to track if the wall is already hidden.

    private void OnCollisionEnter(Collision collision)
    {
        if (!isHidden && collision.gameObject.CompareTag("SphereTag"))
        {
            // Check if the collision was with a sphere (replace "SphereTag" with your actual tag).
            
            // Hide or deactivate the wall GameObject.
            gameObject.SetActive(false);
            isHidden = true; // Set the flag to true so it won't hide again on subsequent collisions.
        }
    }
}
