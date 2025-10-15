using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject coffee, emptyCoffee;

    // Update is called once per frame
    void Update()
    {
        coffee.SetActive(GlobalVariables.coffee > 0);
        emptyCoffee.SetActive(GlobalVariables.emptyCoffee > 0);
    }
}
