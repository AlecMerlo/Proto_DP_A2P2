using UnityEngine;
using UnityEngine.UI;

public class PersonEnergize : MonoBehaviour
{
    public Collider myCollider;

    public Scrollbar mySlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && PickUpCoffee.picked2)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider == myCollider)
                {
                    if (GlobalVariables.coffee > 0)
                    {
                        Energize();
                        GlobalVariables.coffee -= 1;
                    }
                }
                else
                {
                    PickUpCoffee.picked2 = false;
                }
            }
        }
    }

    void Energize()
    {
        PickUpCoffee.picked2 = false;
        mySlider.size = 0.6f;
    }
}
