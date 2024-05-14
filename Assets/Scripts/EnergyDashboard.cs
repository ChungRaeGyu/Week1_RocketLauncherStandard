using System;
using UnityEngine;
using UnityEngine.UI;

public class EnergyDashboard : MonoBehaviour
{
    [SerializeField] private EnergySystem energySystem;
    [SerializeField] private Image fillBar;
    private void Start()
    {
        // TODO : energySystem에서 값이 바뀌면 fillBar.fillAmount가 바뀌도록 변경
        energySystem.OnEnergyChanged += obj =>fillBar.fillAmount -=obj;
    }
    /*원래 식
    private void Start(){
        --핸들러 등록--
        energySystem.OnEnergyChanged += EnergyChanged;
        
    }
    private void EnergyChanged(float obj)
    {
        --핸들러를 통해 받아온 값을 가지고 행동하는 메소드--
        fillBar.fillAmount-= obj;
    }
    */
}