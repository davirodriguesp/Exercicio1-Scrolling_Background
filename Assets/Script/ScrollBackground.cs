using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    Material mat;
    [SerializeField] float velocidade;
    Vector2 offset;
    float offsetY;

    void Awake()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       offsetY += velocidade * Time.deltaTime;
       offset.y = offsetY;
        mat.mainTextureOffset = offset;
    }
}
