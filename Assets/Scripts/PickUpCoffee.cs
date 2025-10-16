using UnityEngine;

public class PickUpCoffee : MonoBehaviour
{
    public static bool picked1, picked2;
    public GameObject cup1, cup2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cup1.SetActive(picked1);
        cup2.SetActive(picked2);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            cup1.transform.position = hit.point;
            cup2.transform.position = hit.point;
        }

    }

    public void EmptyPick()
    {
        picked1 = true;
    }
    public void FullPick()
    {
        picked2 = true;
    }
}