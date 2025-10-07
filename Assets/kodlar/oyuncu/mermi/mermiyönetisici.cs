using System.Collections.Generic;
using UnityEngine;

public class mermiyönetisici : MonoBehaviour
{
    
    [SerializeField] int mermihizi = 8;
    Queue<GameObject> mermilerhavuzu;
    [SerializeField] GameObject mermiprefab;

    void Awake()
    {
        mermilerhavuzu = new Queue<GameObject>();
        for (int i = 0; i < 8; i++)
        {
            //ana amac for dögüsündeki kadar mermi oluşturmak 
            GameObject obje = Instantiate(mermiprefab);
            obje.SetActive(false);//gizliyoz
            mermilerhavuzu.Enqueue(obje);//enque sıra ya sokuyoz 
        }
    }

    void Update()
    {
        // Havuzdaki mermilerin hareketi
        foreach (var mermi in mermilerhavuzu)
        {
            if (mermi.activeInHierarchy)
            {
                mermi.transform.Translate(Vector3.forward * mermihizi * Time.deltaTime);
            }
        }
    }

    public GameObject objyeial()
    {
        GameObject obje = mermilerhavuzu.Dequeue(); //dequ bizim mermiyi baştan almamıza yarıyor
        obje.SetActive(true); //acıyoz
        mermilerhavuzu.Enqueue(obje);// çıkanı geri sıraya sokuyoz 
        return obje; //son olarkta döndürüyourz 
    }

}
