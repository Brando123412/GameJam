using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    [SerializeField] int valueEnergi = 100;
    [SerializeField] int valueOxygen = 100;
    [SerializeField] int timeLowerOxygen;
    private void Awake()
    {

    }
    private void Start()
    {

    }
    private void Update()
    {

    }
    private void FixedUpdate()
    {

    }
    public void InicialitateGame() {
        InvokeRepeating("CurremtTime",0, timeLowerOxygen);
    }
    public void CurremtTime()
    {
        print("gaa");
    }
}
