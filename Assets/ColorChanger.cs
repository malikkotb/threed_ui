using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    // set movementspeed of capsule
    private float movementSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position += new Vector3(movementSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    private void OnCollisionEnter(Collision collision) {
            
        var renderer = this.GetComponent<Renderer>();
        renderer.material = collision.collider.GetComponent<Renderer>().material;

        
    }
}
