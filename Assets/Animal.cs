using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] public string talk { get; set; }
    [SerializeField] float speed;
    float jumpForce = 10;
    
    public TMPro.TextMeshPro info;
    [SerializeField] GameObject selectedMarker;
    bool selected;
    Rigidbody animalRB;
    
    // Start is called before the first frame update
    void Start()
    {
        info.text = $"Animal:{gameObject.name} : Name: {name}";
        selected = false;
        animalRB = GetComponent<Rigidbody>();
    }
    
    
    private void OnMouseDown()
    {
        if (!selected)
        {
            GameManeger.Instance.selectedObj = gameObject;
            selectedMarker.gameObject.SetActive(true);
            selected = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManeger.Instance.selectedObj != null)
        {
            if (GameManeger.Instance.selectedObj.name != gameObject.name && selected)
            {
                selectedMarker.gameObject.SetActive(false);
                selected = false;
            }
        }
    }

    

    public virtual void Walk()
    {
        float inputHorisontzl = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        animalRB.AddForce(Vector3.right * speed * inputHorisontzl);
        animalRB.AddForce(Vector3.forward * speed * inputVertical);

    }
    public virtual void Talk()
    {
        talk = "TALK";
    }
    public virtual void Jamp()
    {
        Debug.Log("jump ");
        animalRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
