using UnityEngine;

public class CameraPos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * Input.GetAxisRaw("Vertical") * 6;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 8,12), transform.position.z);
    }
}
