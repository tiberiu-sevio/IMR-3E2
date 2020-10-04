using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCactus : MonoBehaviour
{
    public float distance;
    public GameObject Cactus;
    Animation CactusAnimation;
    // Start is called before the first frame update
    void Start()
    {
        Cactus = GameObject.FindGameObjectWithTag("Cactus");
        CactusAnimation = Cactus.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, Cactus.transform.position);
        if(distance < 5)
        {
            CactusAnimation.wrapMode = WrapMode.Loop;
            CactusAnimation.Play("Attack");
        }
        else
        {
            CactusAnimation.wrapMode = WrapMode.Loop;
            CactusAnimation.Play("Idle");
        }
    }
}
