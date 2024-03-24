
using UnityEngine;

public class BasketballSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject basketball;
    public void SpawnBasketball()
    {
        Instantiate(basketball,transform.position, Quaternion.identity);


    }
}
