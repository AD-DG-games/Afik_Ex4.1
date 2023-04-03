using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class MyLife : MonoBehaviour
{
    [SerializeField] int countOfLife;
    public int getLife(){
        return this.countOfLife;
    }

    public void SetLife(int number){
        this.countOfLife = number;
        GetComponent<TextMeshPro>().text = "My Life: " + number.ToString();
    }

    public void incLife(){
        SetLife(countOfLife-1);
    }
}
