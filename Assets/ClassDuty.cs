using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClassDuty : MonoBehaviour
{
    public Text txtStudentName;
    public Image imgPhotos;
    public Sprite[] photos;
    string[] students;
    void Start()
    {
        students = new string[]
        {
            "Ania", "Marcin", "Andrzej", "Marysia", "Zosia", "Jakub", "Wiktoria", "Monika", "Grzesiek"
,       };
    }

    public void drawStudent()
    {
        int randomNumber = Random.Range(0, students.Length);
        txtStudentName.text = students[randomNumber];
        imgPhotos.sprite = photos[randomNumber];
    }
}
