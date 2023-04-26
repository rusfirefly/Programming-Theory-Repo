using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    public override void Talk()
    {
        talk = "цюб-цюб-цюб!";
        StartCoroutine(TalkDog());
    }

    IEnumerator TalkDog()
    {
        info.text = $"{talk}";
        yield return new WaitForSeconds(1.5f);
        info.text = $"Animal:{gameObject.name} : Name: {name}";
    }

}
