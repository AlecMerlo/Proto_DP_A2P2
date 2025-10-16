using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class CoffeeBrew : MonoBehaviour
{
    public GameObject progressBar;
    public GameObject cup, cupDone;
    public float timeToMake;
    public TextMeshProUGUI text;

    private IEnumerator coroutine;

    public Collider myCollider;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider == myCollider)
                {
                    if(cupDone.activeSelf)
                    {
                        PickUp();
                    }
                    else if (GlobalVariables.emptyCoffee > 0 && PickUpCoffee.picked1)
                    {
                        StartBrewing();
                    }
                }
                else
                {
                    PickUpCoffee.picked1 = false;
                }
            }
        }
    }

    void StartBrewing()
    {
        PickUpCoffee.picked1 = false;

        GlobalVariables.emptyCoffee -= 1;
        text.gameObject.SetActive(true);
        progressBar.SetActive(true);
        cup.SetActive(true);
        coroutine = Wait();
        StartCoroutine(coroutine);
    }

    void Ready()
    {
        text.gameObject.SetActive(false);
        progressBar.SetActive(false);
        cup.SetActive(false);
        cupDone.SetActive(true);
    }

    void PickUp()
    {
        GlobalVariables.coffee += 1;
        cupDone.SetActive(false);
    }

    public IEnumerator Wait()
    {
        for(float t = 0.1f; t < timeToMake; t+= Time.deltaTime)
        {
            text.text = ((int)(timeToMake - t)).ToString();
            progressBar.GetComponent<Scrollbar>().size = t / timeToMake;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        Ready();
        yield return null;
    }
}
