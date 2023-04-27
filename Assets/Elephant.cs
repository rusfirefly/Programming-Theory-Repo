using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : Animal
{

    public override void Talk()
    {
        talk = "#$%*#&$^@*$^$";
        StartCoroutine(TalkElephant());
    }

    IEnumerator TalkElephant()
    {
        info.text = $"{talk}";
        yield return new WaitForSeconds(1.5f);
        info.text = $"Animal:{gameObject.name} : Name: {name}";
    }

    public override void Jump()
    {
        talk = "Слон прыгать не умет =(";
        StartCoroutine(TalkElephant());

    }
}
