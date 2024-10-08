﻿using UnityEngine;

namespace MyCode.Core
{
    public interface IFactory
    {
        public T CreateAndSetPos<T>(string key, Vector3 pos, bool isActive = true) where T : MonoBehaviour;
        public T Create<T>(string key, bool isActive = true) where T : MonoBehaviour;
        public GameObject Create(string key, bool isActive = true);
        public GameObject CreateAndSetPos(string key, Vector3 pos, bool isActive = true);
        public T CreateScriptableObject<T>(string gameObjectName) where T : ScriptableObject;
        public void InjectObject(object obj);
    }
}
