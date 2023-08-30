using UnityEngine;

namespace DesignPatternSample.Template
{
    public class TemplateApp : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier();
            soldier.Attack();
            Wizard wizard = new Wizard();
            wizard.Attack();
        }
    }
}