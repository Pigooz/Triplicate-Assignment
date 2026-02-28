using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Receiver receiver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Calling");

         if (receiver != null)
         {
            receiver.OnCalled();
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
