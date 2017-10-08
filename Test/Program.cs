using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var go = new GameObject("fff");
            var button= go.AddComponent<Button>();
            button.onClick.AddListener(_onButton);
            button.onClick.Invoke();
            var text = go.AddComponent<Text>();
            text.text = "haha";
            Console.WriteLine(text.text);
            var toggle = go.AddComponent<Toggle>();
            toggle.onValueChanged.AddListener(_onToggle);
            toggle.onValueChanged.Invoke(true);
            toggle.onValueChanged.Invoke(false
                );
            for (int i = 0; i < 4; i++)
            {
                var tr = new GameObject().transform;
                tr.SetParent(go.transform);
                tr.gameObject.AddComponent<Button>();
            }
            Console.WriteLine(go.transform.childCount);
            go.transform.position = new Vector3(5,5,5);
            var buttons = go.GetComponentsInChildren<Button>();
            Console.WriteLine(buttons.Length);
            Console.WriteLine(go.transform.position);
            Console.ReadLine();
        }

        private static void _onToggle(bool arg0)
        {
            Debug.Log(arg0);
        }

        private static void _onButton()
        {
            Debug.Log("button click");
        }
    }
}
