using UnityEngine;

public class yönetici : MonoBehaviour
{
    [SerializeField] private GameObject yokolacakobje;
    void OnCollisionEnter(Collision collision)
    {
        // tagını alıyoz şidmi
        if (collision.gameObject.CompareTag("mermi"))
        {

            yokolacakobje.SetActive(false);
        }
    }
}
