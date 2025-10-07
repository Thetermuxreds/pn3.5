using UnityEngine;

public class hareket : MonoBehaviour
{
    
    [SerializeField] dusmanalrdata dusmandata;
    [SerializeField] private Transform objelerinacilisyeri;
    [SerializeField] private float hiz = 5f;
    [SerializeField] private float superhiz = 10f;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] mermiyönetisici mermiler;
    [SerializeField] int simdikipuan;

    void Update()
    {
        // --- Hareket ---
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * hiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * hiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * hiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * hiz * Time.deltaTime);

        // --- Süper hız ---
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.forward * superhiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.back * superhiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.left * superhiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.right * superhiz * Time.deltaTime);

        // --- Q-E ile dönüş ---
        float rotationInput = 0f;

        if (Input.GetKey(KeyCode.Q))
            rotationInput = -1f; // sola dön
        if (Input.GetKey(KeyCode.E))
            rotationInput = 1f;  // sağa dön

        transform.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);

        // --- Sol tık ile ateş ---
        if (Input.GetMouseButtonDown(0))
        {
            GameObject mermi = mermiler.objyeial(); // havuzdan al
            mermi.transform.position = objelerinacilisyeri.position; // silah ucundan çık
            mermi.transform.rotation = objelerinacilisyeri.rotation; // baktığın yöne dön
        }
    }



}


