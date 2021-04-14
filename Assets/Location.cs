using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{

    [SerializeField]
    private List<Character> CharactersPresent = new List<Character>();

    private void CharacterLocationCallback()
    {
        foreach(Character character in CharactersPresent)
        {
            character.PositionUpdate(this);
        }
    }

    private void Update()
    {
        CharacterLocationCallback();
    }
}
