using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        //Our private field of type T
        private static T instance = null;

        //Our public property of type T
        //This is what our other components will access
        //This is a pattern you see a lot in C#: private fields, with public properties
        public static T Instance
        {
            //This our public "getter"
            get //get instance
            {
                //Our getter checks to see if the private instance is null...
                //If it's not, it returns it -> Remember, we only want ONE instance, ever with a singleton, never more than ONE
                if (instance != null) return instance;

                //if it is null, it first checks the scene, and tries to grab it
                instance = FindObjectOfType<T>();

                //If it's still null after checking the scene, we instantiate a new 
                if (instance == null)
                {
                    instance = new GameObject(typeof(T).Name).AddComponent<T>();
                }

                DontDestroyOnLoad(instance.gameObject); //当场景发生变化时，单例模式将不受任何影响

                //We return the instance
                return instance;
            }
        }
        public virtual void Awake() //销毁单例模式
        {
            if (instance != null) Destroy(gameObject);
        }
    }
