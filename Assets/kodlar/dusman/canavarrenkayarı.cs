using UnityEngine;

public class canavarrenkayarı : MonoBehaviour
{  
    [SerializeField] dusmanalrdata dusmandata;
    [SerializeField] GameObject prefab;
    private void Awake()
    {
        Renderer canavar = prefab.GetComponent<Renderer>();
        canavar.material.color = dusmandata.renk;
    }
   


}
