using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class lab16recycler: MonoBehaviour
{ 
    public float counter;
    public float bob;
    public Vector3 joe;
    float num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(4,4);
        bob = -28f;
         joe = new Vector3(bob, num, 1f);
         transform.position = joe;


    }

    // Update is called once per frame
    void Update()
    {
      bob = bob + 0.2f;
          joe = new Vector3(bob, num, 1f);
          transform.position = joe;

        if (transform.position.x >= 60)
        {
          bob = -28f;
          joe = new Vector3(bob, num, 1f);
          transform.position = joe;
          num = Random.Range(4,4);
        }
    }
       public void resetGame()
   {
        joe = new Vector3(23.8f, 0.3f, 0f);
        transform.position = joe;
  }
}
    